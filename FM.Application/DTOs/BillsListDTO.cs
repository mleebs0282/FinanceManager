using FM.Domain.Models;
using System.Collections.Generic;

namespace FM.Application.DTOs
{
    public class BillsListDTO
    {
        public IEnumerable<Bill> Bills { get; set; }
    }
}
