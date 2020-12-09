using FM.Application.DTOs;

namespace FM.Application.Interfaces
{
    public interface IBillService
    {
        BillsListDTO GetAllBills();

        BillDTO GetBillById(int id);

        void AddNewBill(BillDTO bill);

        void UpdateBill(BillDTO bill);

        void DeleteBill(int id);
    }
}
