using System.Collections.Generic;
using Acelera.OO.CarRental.AdditionalItems;

namespace Acelera.OO.CarRental.Contracts
{
    public abstract class Contract
    {
        public string CarType { get; protected set; }

        protected ICollection<AdditionalItem> additionalItems;

        protected abstract double GetDailyValue();

        protected abstract double GetAdditionalKm();
    }
}
