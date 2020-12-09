using FM.Domain.Interfaces;
using FM.Domain.Models;
using FM.Infrastructure.Data.Context;
using System.Linq;

namespace FM.Infrastructure.Data.Repositories
{
    public class BudgetRepository : IBudgetRepository
    {
        public FinanceDbContext _context;
        public BudgetRepository(FinanceDbContext context)
        {
            _context = context;
        }

        public Budget GetBudget(int id)
        {
            return _context.Budget
                    .Where(b => b.Id == id)
                    .FirstOrDefault();
        }

        public void UpdateBudget(Budget budget)
        {
            _context.Update(budget);
            _context.SaveChanges();
        }
    }
}
