using FM.Application.DTOs;
using FM.Application.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace FM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillController : ControllerBase
    {
        private IBillService _billService;
        public BillController(IBillService billService)
        {
            _billService = billService;
        }

        [HttpGet]
        public BillsListDTO Get()
        {
            return _billService.GetAllBills();
        }

        [HttpGet("{id}")]
        public BillDTO Get(int id)
        {
            return _billService.GetBillById(id);
        }

        [HttpPost]
        public void Post(BillDTO bill)
        {
            _billService.AddNewBill(bill);
        }

        [HttpPut("{id}")]
        public void Put(BillDTO bill)
        {
            _billService.UpdateBill(bill);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _billService.DeleteBill(id);
        }
    }
}
