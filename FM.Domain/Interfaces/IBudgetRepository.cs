using FM.Domain.Models;

namespace FM.Domain.Interfaces
{
    public interface IBudgetRepository
    {
        Budget GetBudget(int id);

        void UpdateBudget(Budget budget);
    }
}
