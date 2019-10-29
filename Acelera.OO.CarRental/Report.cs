using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Acelera.OO.CarRental.Vehicles;

namespace Acelera.OO.CarRental
{
    public class Report
    {
        List<Contract> Contracts { get; set; }

        public Report(List<Contract> contracts)
        {
            Contracts = contracts;
        }

        public string GenerateReportByVehicleType()
        {
            string result = "";
            foreach (var item in Contracts)
            {
                result += "Tipo do Carro: " + item.Vehicle.GetCarType() + "\n" +
                "Quantidade de diárias: " + item.DailyAmount + "\n" +
                "Valor total das diárias: R$ " + item.TotalAmountDaily.ToString("N2") + "\n" +
                "Estimativa de quilometragem em reais: R$ " + item.TotalAmountAdditionalKm.ToString("N2") + "\n" +
                "Valor de todos os adicionais: " + GetAdditionalItensValue(item.Vehicle) + "\n" +
                "Valor total do aluguel: R$ " + item.Total.ToString("N2") + "\n";
            }

            return result;
        }

        public string GetAdditionalItensValue(Vehicle vehicle)
        {
            string result = "";

            foreach (var item in vehicle.AdditionalItems)
            {
                result += item.Description + ": R$ " + item.Value.ToString("N2") + " ";
            }

            return result;
        }
    }
}
