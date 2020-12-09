using FM.Domain.Models;
using System.Collections.Generic;

namespace FM.Domain.Interfaces
{
    public interface IBillRepository
    {
        IEnumerable<Bill> GetAllBills();

        Bill GetBillById(int id);

        void AddNewBill(Bill bill);

        void UpdateBill(Bill bill);

        void DeleteBill(int id);
    }
}