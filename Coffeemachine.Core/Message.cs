using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffeemachine.Core
{
    public class Message
    {
        public Message(string text)
        {
            if (string.IsNullOrEmpty(text))
                throw new ArgumentNullException("Il messaggio non deve essere vuoto");
            _text = text;
        }

        private string _text;
        public string Text => _text;

        public override string ToString()
        {
            return $"M:{Text}";
        }
    }
}
