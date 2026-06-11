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

        // Mengambil data dari Helper, dibungkus ke List<CustomerModel>, lalu dikembalikan
        public List<EntityCustomerAdmin> GetCustomerList()
        {
            return _helper.GetAllCustomers();
        }

        // Menangani logika penonaktifan akun
        public bool ToggleCustomerStatus(int id, bool currentStatus)
        {
            // Jika tadinya true (aktif), diubah jadi false (nonaktif), dan sebaliknya
            bool newStatus = !currentStatus;
            return _helper.UpdateStatus(id, newStatus);
        }
    }
}
