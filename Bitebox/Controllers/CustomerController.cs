using Bitebox.Models.Context;
using Bitebox.Models.Entity;

namespace Bitebox.Controllers
{
    internal class CustomerController
    {
        private readonly CustomerContext _context = new CustomerContext();

        public List<EntityCustomerAdmin> GetCustomerList()
        {
            return _context.GetAllCustomers();
        }

        public bool ToggleCustomerStatus(int id, bool isAktifSekarang)
        {
            return _context.UpdateStatus(id, !isAktifSekarang);
        }
    }
}