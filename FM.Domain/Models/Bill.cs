using System;
using System.Collections.Generic;
using System.Text;

namespace FM.Domain.Models
{
    public class Bill
    {
        public int Id { get; set; }
        public string Payee { get; set; }
        public int DayDue { get; set; }
        public double AmountDue { get; set; }
        public double Balance { get; set; }
        public string Type { get; set; }
        public Website Website { get; set; }
    }
}
