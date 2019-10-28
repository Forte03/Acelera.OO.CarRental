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

        public StringBuilder GenerateReportByVehicleType()
        {
            StringBuilder result = new StringBuilder();
            foreach (var item in Contracts)
            {
                result.AppendLine("Tipo do Carro: " + item.Vehicle.GetCarType());
                result.AppendLine("Quantidade de diárias: " + item.DailyAmount);
                result.AppendLine("Valor total das diárias: R$ " + item.TotalAmountDaily);
                result.AppendLine("Estimativa de quilometragem em reais: R$ " + item.TotalAmountAdditionalKm);
                result.AppendLine("Valor de todos os adicionais: " + GetAdditionalItensValue(item.Vehicle));
                result.AppendLine("Valor total do aluguel: R$ " + item.Total);
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
