using System;
using Acelera.OO.CarRental.Contracts;

namespace Acelera.OO.CarRental
{
    public class ContractReceipt
    {
        private Contract contract;

        public DateTime StartDate { get; private set; }

        public DateTime EndDate { get; private set; }

        public int DailyAmount
        {
            get
            {
                return EndDate.Subtract(StartDate).Days;
            }
        }

        public double TotalAmountDaily { get; protected set; }

        public double TotalAmountAdditionalKm { get; protected set; }

        public double Total { get; set; }

        public ContractReceipt(Contract contract, DateTime startDate, DateTime endDate)
        {
            this.contract = contract;
            StartDate = startDate;
            EndDate = endDate;
        }

        public void Calculate()
        {

        }
    }
}
