using System;
using System.Collections.Generic;
using System.Text;

namespace Bitebox.Models.Entity
{
    public class Customer : Akun
    {
        public Customer(int idAkun, string username, string passwordAkun, string namaLengkap, string email, bool isAktif)
            : base(idAkun, username, passwordAkun, namaLengkap, email, "customer", isAktif)
        {
        }
        public override string GetHakAksesDashboard()
        {
            return $"Selamat Datang {NamaLengkap}! Anda masuk sebagai Customer. Anda bisa memesan makanan."; //nanti tak perbaiki bahasanya biar ga kaya ai
        }
    }
}