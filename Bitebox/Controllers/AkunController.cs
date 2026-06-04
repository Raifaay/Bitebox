using System;
using Bitebox.Models.Context;
using Bitebox.Models.Entity;

namespace Bitebox.Controllers
{
    internal class AkunController
    {
        private AkunContext akunContext = new AkunContext();

        public Akun? Login(string usernameOrEmail, string password)
        {
            return akunContext.GetAkunByCredentials(usernameOrEmail, password);
        }

        public bool Register(string namaLengkap, string email, string username, string password)
        {
            return akunContext.InsertAkun(namaLengkap, email, username, password);
        }
    }
}