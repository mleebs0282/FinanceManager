using System;
using System.Collections.Generic;
using System.Text;

namespace FM.Domain.Models
{
    public class Website
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public Login Login { get; set; }
    }
}
