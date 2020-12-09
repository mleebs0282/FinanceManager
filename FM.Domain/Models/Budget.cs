using System;
using System.Collections.Generic;
using System.Text;

namespace FM.Domain.Models
{
    public class Budget
    {
        public int Id { get; set; }
        public double Income { get; set; }
        public double Bills { get; set; }
        public double Groceries { get; set; }
        public double Meals { get; set; }
        public double Savings { get; set; }
        public double Giving { get; set; }
        public double Living { get; set; }
        public double Emergency { get; set; }
        public double Unallocated { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
