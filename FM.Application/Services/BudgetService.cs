using FM.Application.DTOs;
using FM.Application.Interfaces;
using FM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FM.Application.Services
{
    public class BudgetService : IBudgetService
    {
        public IBudgetRepository _budgetRepository;
        public BudgetService(IBudgetRepository budgetRepository)
        {
            _budgetRepository = budgetRepository;
        }

        public BudgetDTO GetBudget(int id)
        {
            return new BudgetDTO()
            {
                Budget = _budgetRepository.GetBudget(id)
            };
        }

        public void UpdateBudget(BudgetDTO dto)
        {
            _budgetRepository.UpdateBudget(dto.Budget);
        }
    }
}
