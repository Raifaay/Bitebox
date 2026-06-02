using System;
using Bitebox.Models.Entity;
using Bitebox.Models.Context; // Memanggil namespace context yang baru dibuat

namespace Bitebox.Controllers
{
    internal class AkunController
    {
        private readonly AkunContext _akunContext;

        public AkunController()
        {
            // Inisialisasi data access / context layer di constructor
            _akunContext = new AkunContext();
        }

        public Akun Login(string usernameOrEmail, string password)
        {
            // Controller hanya menjembatani ke model context
            return _akunContext.GetAkunByCredentials(usernameOrEmail, password);
        }

        public bool Register(string namaLengkap, string email, string username, string password)
        {
            // Controller meneruskan data registrasi ke model context
            return _akunContext.InsertAkun(namaLengkap, email, username, password);
        }
    }
}