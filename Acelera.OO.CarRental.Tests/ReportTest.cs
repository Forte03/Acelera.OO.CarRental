using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acelera.OO.CarRental;
using System.Collections.Generic;
using System.Text;
using System;

namespace Acelera.OO.CarRental.Tests
{
    [TestClass]
    public class ReportTest
    {
        [TestMethod]
        public void ShouldGenerateReportByVehicleType()
        {
            var car = new Vehicles.Car();
            var motorHome = new Vehicles.MotorHome();
            var contractList = new List<Contract>();

            var contractCar = new Contract(car, DateTime.Now, DateTime.Now.AddDays(10), 200);
            var contractMotorHome = new Contract(motorHome, DateTime.Now, DateTime.Now.AddDays(10), 200);

            contractList.Add(contractMotorHome);
            contractList.Add(contractCar);

            var report = new Report(contractList);

            Assert.AreEqual(MockGerateReportByVehicleType(), report.GenerateReportByVehicleType().ToString());
        }

        public string MockGerateReportByVehicleType()
        {
            var result =
                "Tipo do Carro: Motor Home\n" +
                "Quantidade de diárias: 10\n" +
                "Valor total das diárias: R$ 3.000,00\n" +
                "Estimativa de quilometragem em reais: R$ 130,00\n" +
                "Valor de todos os adicionais: GPS: R$ 35,00 Cadeirinha: R$ 75,00 Geladeira: R$ 250,00 \n" +
                "Valor total do aluguel: R$ 3.490,00\n" +
                "Tipo do Carro: Carro\n" +
                "Quantidade de diárias: 10\n" +
                "Valor total das diárias: R$ 500,00\n" +
                "Estimativa de quilometragem em reais: R$ 100,00\n" +
                "Valor de todos os adicionais: GPS: R$ 25,00 Cadeirinha: R$ 65,00 \n" +
                "Valor total do aluguel: R$ 690,00\n";

            return result;
        }
    }
}
