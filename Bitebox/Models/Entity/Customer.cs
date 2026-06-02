using System;
using System.Collections.Generic;
using System.Text;

namespace Bitebox.Models.Entity
{
    internal class Customer : Akun
    {
        public Customer() { }
        public Customer(int idAkun, string username, string namaLengkap, string email, string role) : base(idAkun, username, namaLengkap, email, role)
        {
        }
    }
}