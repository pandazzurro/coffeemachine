using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffeemachine.Core
{
    public class DrinkMaker
    {
        private ICoffeMachine _coffeMachineService;
        private Drink _drink;
        private decimal _currentMoney;
        public DrinkMaker(decimal currentMoney, Drink drink , ICoffeMachine coffeMachineService)
        {
            if(currentMoney < 0)
                throw new ArgumentException(nameof(currentMoney));
            if (drink == null)
                throw new ArgumentNullException(nameof(drink));
            if (coffeMachineService == null)
                throw new ArgumentNullException(nameof(coffeMachineService));

            _drink = drink;
            _coffeMachineService = coffeMachineService;
            _currentMoney = currentMoney;
        }
        
        public decimal? Deliver()
        {
            // Credito insufficiente
            if (_drink.Price > _currentMoney)
            {
                _coffeMachineService.SendMessage("Credito insufficiente");
                return null;
            }
            // Credito sufficiente e calcolo del resto
            else
            {
                return _currentMoney - _drink.Price;
            }
        }
    }
}
