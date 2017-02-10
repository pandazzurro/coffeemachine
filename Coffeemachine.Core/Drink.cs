using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffeemachine.Core
{
    public abstract class Drink
    {
        public Drink(short sugar, decimal price)
        {
            if (sugar < 0 || sugar > 2)
                throw new ArgumentException("Dosi di zucchero errate");

            if (price < 0)
                throw new ArgumentException("Il prezzo deve essere positivo");

            Sugar = sugar;
            Price = price;
        }

        protected char TypeOfDrink { get; set; }
        public char Type => TypeOfDrink;
        public short Sugar { get; protected set; }
        public bool Stick => Sugar > 0 ? true : false;
        public decimal Price { get; protected set; }

        public void AddSugar()
        {
            Sugar += 1;
        }

        public void RemoveSugar()
        {
            Sugar -= 1;
        }

        public override string ToString()
        {
            string stickValue = Stick ? "0" : string.Empty;
            string sugarValue = Sugar > 0 ? Sugar.ToString() : string.Empty;
            return $"{Type}:{sugarValue}:{stickValue}";
        }
    }

    public sealed class Chocolate : Drink
    {
        public Chocolate(short sugar) : base(sugar, 0.5M)
        {
            TypeOfDrink = 'H';
        }
    }

    public sealed class Coffe : Drink
    {
        public Coffe(short sugar) : base(sugar, 0.6M)
        {
           TypeOfDrink = 'C';
        }
    }

    public sealed class Tea : Drink
    {
        public Tea(short sugar) : base(sugar, 0.4M)
        {
            TypeOfDrink = 'T';
        }
    }
}
