using FM.Application.DTOs;

namespace FM.Application.Interfaces
{
    public interface IBudgetService
    {
        BudgetDTO GetBudget(int id);

        void UpdateBudget(BudgetDTO budget);
    }
}
