using Coffeemachine.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Coffemachine.Test
{
    public class MessageTest
    {
        [Fact]
        public void MessageTest_Ctor()
        {
            Assert.Throws<ArgumentNullException>(() => new Message(string.Empty));            
            Assert.NotNull(new Message("Messaggio per utente"));
        }

        [Fact]
        public void MessageTest_ToString()
        {
            var m = new Message("Messaggio per utente");
            Assert.Equal("M:Messaggio per utente", m.ToString());
        }
    }
}
