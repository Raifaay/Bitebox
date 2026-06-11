using Bitebox.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using Bitebox.Models.Entity;

namespace Bitebox.Controllers
{
    internal class CustomerController
    {
        private CustomerHelper _helper = new CustomerHelper();
        public List<EntityCustomerAdmin> GetCustomerList()
        {
            return _helper.GetAllCustomers();
        }


        public bool ToggleCustomerStatus(int id, bool currentStatus)
        {

            bool newStatus = !currentStatus;
            return _helper.UpdateStatus(id, newStatus);
        }
    }
}
