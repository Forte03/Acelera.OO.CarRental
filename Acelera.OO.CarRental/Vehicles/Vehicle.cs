using System.Collections.Generic;
using Acelera.OO.CarRental.AdditionalItems;

namespace Acelera.OO.CarRental.Vehicles
{
    public abstract class Vehicle
    {
        public string CarType { get; protected set; }
        public ICollection<AdditionalItem> AdditionalItems { get; set; }
        public abstract double GetDailyValue();
        public abstract double GetAdditionalKm();
        public abstract string GetCarType();
    }
}
