using FM.Application.DTOs;
using FM.Application.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BudgetController : ControllerBase
    {
        private IBudgetService _budgetService;
        public BudgetController(IBudgetService budgetService)
        {
            _budgetService = budgetService;
        }

        [HttpGet("{id}")]
        [EnableCors("Open")]
        public BudgetDTO Get(int id)
        {
            return _budgetService.GetBudget(id);
        }

        [HttpPut("{id}")]
        public void Put(BudgetDTO budget)
        {
            _budgetService.UpdateBudget(budget);
        }
    }
}
