using System.Collections.Generic;
using Acelera.OO.CarRental.AdditionalItems;

namespace Acelera.OO.CarRental.Vehicles
{
    public class Car : Vehicle
    {
        public Car()
        {
            InsertAdditionalItems();
        }

        public override string GetCarType() =>
            "Carro";

        public override double GetAdditionalKm() =>
            0.5;

        public override double GetDailyValue() =>
            50;
        private void InsertAdditionalItems()
        {
            this.AdditionalItems = new List<AdditionalItem>()
            {
                new GPS(25),
                new CarSeat(65)
            };
        }
    }
}
