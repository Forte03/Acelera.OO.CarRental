using System.Collections.Generic;
using Acelera.OO.CarRental.AdditionalItems;

namespace Acelera.OO.CarRental.Vehicles
{
    public class MotorHome : Vehicle
    {
        public MotorHome()
        {
            InsertAdditionalItems();
        }
        public override string GetCarType() =>
            "Motor Home";

        public override double GetAdditionalKm() =>
            0.65;

        public override double GetDailyValue() =>
            300;

        private void InsertAdditionalItems()
        {
            this.AdditionalItems = new List<AdditionalItem>()
            {
                new GPS(35),
                new CarSeat(75),
                new Refrigerator(250)
            };
        }
    }
}
