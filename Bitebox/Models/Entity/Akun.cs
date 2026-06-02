using System;
using System.Collections.Generic;
using System.Text;

namespace Bitebox.Models.Entity
{
    internal class Akun 
    {
        private int idAkun;
        private string username;
        private string password;
        private string namaLengkap;
        private string email;
        private string role;

        public int IdAkun
        { 
            get { return idAkun; } 
            set { idAkun = value; }
        }
        public string Username 
        { 
            get { return username; } 
            set { username = value; } 
        }
        public string Password 
        { 
            get { return password; } 
            set { password = value; } 
        }
        public string NamaLengkap 
        { 
            get { return namaLengkap; } 
            set { namaLengkap = value; } 
        }
        public string Email 
        { 
            get { return email; } 
            set { email = value; } 
        }
        public string Role 
        { 
            get { return role; } 
            set { role = value; } 
        }

        public Akun() { }

        public Akun(int idAkun, string username, string namaLengkap, string email, string role)
        {
            this.idAkun = idAkun;
            this.username = username;
            this.namaLengkap = namaLengkap;
            this.email = email;
            this.role = role;
        }
    }
}

