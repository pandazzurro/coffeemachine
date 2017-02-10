using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffeemachine.Core
{
    public class IncomingOrder
    {
        private Drink _drink;
        private Message _message;
        public IncomingOrder()
        {

        }

        public void AddDrink(Drink d)
        {
            _drink = d;
            // Se il drink era settato, rettifico l'ordine con il nuovo messaggio
            if (_message != null)
                _message = null;
        }

        public void AddMessage(Message m)
        {
            _message = m;
            // Se il drink era settato, rettifico l'ordine con il nuovo messaggio
            if (_drink != null)
                _drink = null;
        }

        public string GetOrder()
        {
            if (_drink != null)
                return _drink.ToString();
            if (_message != null)
                return _message.ToString();
            throw new InvalidOperationException("Nessun ordine effettuato");
        }
    }
}
