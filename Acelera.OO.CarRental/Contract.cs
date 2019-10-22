using System;
using System.Collections.Generic;

namespace CarRental
{
    public class Contract
    {
        Vehicle vehicle;
        private float dailyPrice;
        private float kmPrice;
        private DateTime rentDate;
        private DateTime returnDate;
        List<IItem> itens;

        public Contract(List<IItem> itens)
        {
            this.itens = itens;
        }

        protected void SetDailyPrice(string vehicleType)
        {
            
        }
    }
}
