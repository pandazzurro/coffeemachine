using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffeemachine.Core
{
    public interface ICoffeMachine
    {
        void SendMessage(string message);
    }

    public class CoffeMachine : ICoffeMachine
    {
        public void SendMessage(string message)
        {
            // Non viene specificato nessun comportamento nell'esercizio
            System.Diagnostics.Debug.WriteLine(message);
        }
    }
}
