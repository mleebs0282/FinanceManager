using FM.Application.DTOs;
using FM.Application.Interfaces;
using FM.Domain.Interfaces;

namespace FM.Application.Services
{
    public class BillService : IBillService
    {
        public IBillRepository _billRepository;
        public BillService(IBillRepository billRepository)
        {
            _billRepository = billRepository;
        }

        public BillsListDTO GetAllBills()
        {
            return new BillsListDTO()
            {
                Bills = _billRepository.GetAllBills()
            };
        }

        public BillDTO GetBillById(int id)
        {
            return new BillDTO()
            {
                Bill = _billRepository.GetBillById(id)
            };
        }

        public void AddNewBill(BillDTO dto)
        {
            _billRepository.AddNewBill(dto.Bill);
        }

        public void UpdateBill(BillDTO dto)
        {
            _billRepository.UpdateBill(dto.Bill);
        }

        public void DeleteBill(int id)
        {
            _billRepository.DeleteBill(id);
        }
    }
}
