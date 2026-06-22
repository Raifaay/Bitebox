using System;
using System.Collections.Generic;
using System.Text;

namespace Bitebox.Models.Entity
{
    public class Customer : Akun
    {
        public Customer(int idAkun, string username, string passwordAkun, string namaLengkap, string email, bool isAktif)
            : base(idAkun, username, passwordAkun, namaLengkap, email, "customer", isAktif)
        { // apa ayang baru juga
        }
        public override string GetHakAksesDashboard() // kalo bisa tambahin param biar ga return stringa aj
        {
            return $"Selamat Datang {NamaLengkap}! Anda masuk sebagai Customer. Anda bisa memesan makanan."; 
        }
    }
}