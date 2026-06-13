using System;
using System.Collections.Generic;
using System.Text;

namespace Bitebox.Models.Entity
{
    public class Admin : Akun
    {
        public Admin(int idAkun, string username, string passwordAkun, string namaLengkap, string email, bool isAktif)
            : base(idAkun, username, passwordAkun, namaLengkap, email, "admin", isAktif)
        {
        }
        public override string GetHakAksesDashboard()
        {
            return $"Peringatan Keamanan! {NamaLengkap} masuk sebagai Administrator. Anda memiliki akses penuh ke manajemen menu."; //ini juga tak benerin
        }
    }
}
