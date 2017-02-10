using Coffeemachine.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Coffemachine.Test
{
    public class IncomingOrderTest
    {
        [Fact]
        public void IncomingOrderTest_ToString()
        {

            IncomingOrder orderEmpty = new IncomingOrder();
            Assert.Throws<InvalidOperationException>(() => orderEmpty.GetOrder());

            IncomingOrder orderDrink = new IncomingOrder();
            orderDrink.AddDrink(new Chocolate(2));
            Assert.Equal("H:2:0", orderDrink.GetOrder());

            IncomingOrder orderMessage = new IncomingOrder();
            orderMessage.AddMessage(new Message("Mex"));
            Assert.Equal("M:Mex", orderMessage.GetOrder());
            
            orderMessage.AddDrink(new Chocolate(2));
            Assert.Equal("H:2:0", orderMessage.GetOrder());
            
            orderMessage.AddMessage(new Message("Mex"));
            Assert.Equal("M:Mex", orderMessage.GetOrder());
        }
    }
}
