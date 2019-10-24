using System.Collections.Generic;
using Acelera.OO.CarRental.AdditionalItems;

namespace Acelera.OO.CarRental.Contracts
{
    public class CarContract : Contract
    {
        public CarContract()
        {
            InsertAdditionalItems();
        }

        protected override double GetAdditionalKm() =>
            0.5;

        protected override double GetDailyValue() =>
            50;

        private void InsertAdditionalItems()
        {
            this.additionalItems = new List<AdditionalItem>()
            {
                new GPS(25),
                new CarSeat(65)
            };
        }
    }
}
