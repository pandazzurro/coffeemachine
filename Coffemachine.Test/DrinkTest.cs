using System;
using Coffeemachine.Core;
using Xunit;

namespace Coffemachine.Test
{

    public class DrinkTest
    {
        [Fact]
        public void DrinkTest_CheckStick()
        {
            var c = (Drink)new Chocolate(0);
            Assert.Equal(false, c.Stick);

            var c1 = (Drink)new Chocolate(1);
            Assert.Equal(true, c1.Stick);
        }

        [Fact]
        public void DrinkTest_AddSugar()
        {
            var c = (Drink)new Chocolate(0);
            Assert.Equal(false, c.Stick);
            Assert.Equal(0, c.Sugar);

            c.AddSugar();
            Assert.Equal(true, c.Stick);
            Assert.Equal(1, c.Sugar);


            c.RemoveSugar();
            Assert.Equal(false, c.Stick);
            Assert.Equal(0, c.Sugar);
        }
    }

    public class ChocolateTest
    {
        [Fact]
        public void ChocolateTest_Ctor()
        {
            Assert.Throws<ArgumentException>(() => new Chocolate(-1));
            Assert.Throws<ArgumentException>(() => new Chocolate(3));
            Assert.NotNull(new Chocolate(1));
            Assert.NotNull(new Chocolate(2));
            Assert.NotNull(new Chocolate(0));
        }

        [Fact]
        public void ChocolateTest_ToString()
        {
            var c = new Chocolate(1);            
            Assert.Equal("H:1:0", c.ToString());

            var c1 = new Chocolate(0);
            Assert.Equal("H::", c1.ToString());

            var c2 = new Chocolate(2);
            Assert.Equal("H:2:0", c2.ToString());
        }
    }

    public class TeaTest
    {
        [Fact]
        public void TeaTest_Ctor()
        {
            Assert.Throws<ArgumentException>(() => new Tea(-1));
            Assert.Throws<ArgumentException>(() => new Tea(3));
            Assert.NotNull(new Tea(1));
            Assert.NotNull(new Tea(2));
            Assert.NotNull(new Tea(0));
        }

        [Fact]
        public void TeaTest_ToString()
        {
            var c = new Tea(1);
            Assert.Equal("T:1:0", c.ToString());

            var c1 = new Tea(0);
            Assert.Equal("T::", c1.ToString());

            var c2 = new Tea(2);
            Assert.Equal("T:2:0", c2.ToString());
        }
    }

    public class CoffeTest
    {
        [Fact]
        public void CoffeTest_Ctor()
        {
            Assert.Throws<ArgumentException>(() => new Coffe(-1));
            Assert.Throws<ArgumentException>(() => new Coffe(3));
            Assert.NotNull(new Coffe(1));
            Assert.NotNull(new Coffe(2));
            Assert.NotNull(new Coffe(0));
        }

        [Fact]
        public void CoffeTest_ToString()
        {
            var c = new Coffe(1);
            Assert.Equal("C:1:0", c.ToString());

            var c1 = new Coffe(0);
            Assert.Equal("C::", c1.ToString());

            var c2 = new Coffe(2);
            Assert.Equal("C:2:0", c2.ToString());
        }
    }
}
