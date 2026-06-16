using Bitebox.Helpers;
using Bitebox.Models.Entity;

namespace Bitebox.Controllers
{
    internal class CustomerController
    {
        private readonly CustomerHelper _helper = new CustomerHelper();

        public List<EntityCustomerAdmin> GetCustomerList()
        {
            return _helper.GetAllCustomers();
        }

        public bool ToggleCustomerStatus(int id, bool isAktifSekarang)
        {
            return _helper.UpdateStatus(id, !isAktifSekarang);
        }
    }
}