using Bitebox.Models.Context;
using System;
using System.Data;

namespace Bitebox.Controllers
{
    public class CustomerController
    {
        private readonly AkunContextAdmin _context = new AkunContextAdmin();

        public DataTable GetCustomerList()
        {
            try
            {
                return _context.GetCustomerFromDatabase();
            }
            catch (Exception ex)
            {
                throw new Exception("Error di CustomerController: " + ex.Message);
            }
        }

        public bool ToggleCustomerStatus(int idAkun, bool statusSaatIni)
        {
            try
            {
                _context.ExecuteNonaktifkanCustomer(idAkun);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}