using System;

namespace Bitebox.Models.Entity
{
    public abstract class Akun
    {
        public int IdAkun { get; set; }
        public string Username { get; set; }
        public string PasswordAkun { get; set; }
        public string NamaLengkap { get; set; }
        public string Email { get; set; }
        public string RoleAkun { get; set; } 
        public bool IsAktif { get; set; } = true;

      
        protected Akun(int idAkun, string username, string passwordAkun, string namaLengkap, string email, string roleAkun, bool isAktif)
        {
            this.IdAkun = idAkun;
            this.Username = username;
            this.PasswordAkun = passwordAkun;
            this.NamaLengkap = namaLengkap;
            this.Email = email;
            this.RoleAkun = roleAkun;
            this.IsAktif = isAktif;
        }

        public abstract string GetHakAksesDashboard();
    }
}