using System;
using System.Linq;
using Acelera.OO.CarRental.Vehicles;

namespace Acelera.OO.CarRental
{
    public class Contract
    {
        public Vehicle Vehicle { get; set; }

        public DateTime StartDate { get; private set; }

        public DateTime EndDate { get; private set; }

        public int Km { get; set; }

        public int DailyAmount
        {
            get
            {
                return EndDate.Subtract(StartDate).Days;
            }
        }

        public double TotalAmountDaily { get; private set; }

        public double TotalAmountAdditionalKm { get; private set; }

        public double Total { get; private set; }
        private double totalValueItens;

        public Contract(Vehicle vehicle, DateTime startDate, DateTime endDate, int km)
        {
            Vehicle = vehicle;
            StartDate = startDate;
            EndDate = endDate;
            Km = km;
            Calculate();
        }

        private void Calculate()
        {
            GetTotalItens();
            CalculateTotalAmountDaily();
            CalculateTotalAmountAdditionalKm();
            CalculateTotal();
        }

        private void GetTotalItens()
        {
            totalValueItens = Vehicle.AdditionalItems.Sum(x => x.Value);
        }

        private void CalculateTotalAmountDaily()
        {
            TotalAmountDaily = DailyAmount * Vehicle.GetDailyValue();
        }

        private void CalculateTotalAmountAdditionalKm()
        {
            TotalAmountAdditionalKm = Vehicle.GetAdditionalKm() * Km;
        }

        private void CalculateTotal()
        {
            Total = TotalAmountAdditionalKm + TotalAmountDaily + totalValueItens;
        }
    }
}
