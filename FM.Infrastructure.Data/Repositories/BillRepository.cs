using FM.Domain.Interfaces;
using FM.Domain.Models;
using FM.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FM.Infrastructure.Data.Repositories
{
    public class BillRepository : IBillRepository
    {
        public FinanceDbContext _context;
        public BillRepository(FinanceDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Bill> GetAllBills()
        {
            return _context.Bills
                .Include(w => w.Website)
                .ThenInclude(l => l.Login)
                .OrderBy(b => b.DayDue);
        }

        public Bill GetBillById(int id)
        {
            return _context.Bills
                .Include(w => w.Website)
                .ThenInclude(l => l.Login)
                .Where(i => i.Id == id).FirstOrDefault();
        }

        public void AddNewBill(Bill bill)
        {
            _context.Add(bill);
            _context.SaveChanges();
        }

        public void UpdateBill(Bill bill)
        {
            _context.Update(bill);
            _context.SaveChanges();
        }

        public void DeleteBill(int id)
        {
            _context.Remove(id);
            _context.SaveChanges();
        }
    }
}
