using Coffeemachine.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Coffemachine.Test
{
    public class DrinkMakerTest
    {
        [Fact]
        public void DrinkMakerTest_CtorKo()
        {
            var coffeMachineService = new CoffeMachine();
            Assert.Throws<ArgumentException>(() => new DrinkMaker(-1, new Chocolate(2), coffeMachineService));
            Assert.Throws<ArgumentNullException>(() => new DrinkMaker(1, null, coffeMachineService));
            Assert.Throws<ArgumentNullException>(() => new DrinkMaker(1, new Chocolate(2), null));
        }

        [Fact]
        public void DrinkMakerTest_CreditoInsufficiente()
        {
            var coffeMachineService = new CoffeMachine();
            var drinkMaker = new DrinkMaker(0.3M, new Chocolate(2), coffeMachineService);
            Assert.Equal(null, drinkMaker.Deliver());
        }

        [Fact]
        public void DrinkMakerTest_CreditoConResto()
        {
            var coffeMachineService = new CoffeMachine();
            var drinkMaker = new DrinkMaker(0.6M, new Chocolate(2), coffeMachineService);
            Assert.True(0.1M == drinkMaker.Deliver());
        }

        [Fact]
        public void DrinkMakerTest_CreditoSenzaResto()
        {
            var coffeMachineService = new CoffeMachine();
            var drinkMaker = new DrinkMaker(0.5M, new Chocolate(2), coffeMachineService);
            Assert.True(0.0M == drinkMaker.Deliver());
        }

        
        [Fact]
        public void DrinkMakerTest_Chocolate()
        {
            var coffeMachineService = new CoffeMachine();
            var drinkMaker = new DrinkMaker(0.5M, new Chocolate(2), coffeMachineService);
            Assert.True(0.0M == drinkMaker.Deliver());
        }

        [Fact]
        public void DrinkMakerTest_Tea()
        {
            var coffeMachineService = new CoffeMachine();
            var drinkMaker = new DrinkMaker(0.4M, new Tea(2), coffeMachineService);
            Assert.True(0.0M == drinkMaker.Deliver());
        }

        [Fact]
        public void DrinkMakerTest_Coffe()
        {
            var coffeMachineService = new CoffeMachine();
            var drinkMaker = new DrinkMaker(0.6M, new Coffe(2), coffeMachineService);
            Assert.True(0.0M == drinkMaker.Deliver());
        }
    }
}
