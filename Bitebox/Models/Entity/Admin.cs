using System;
using System.Collections.Generic;
using System.Text;

namespace Bitebox.Models.Entity
{
    internal class Admin : Akun
    {
        public Admin() { }
        public Admin(int idAkun, string username, string namaLengkap, string email, string role) : base(idAkun, username, namaLengkap, email, role)
        {
        }
    }
}
