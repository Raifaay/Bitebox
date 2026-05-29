using System;
using System.Collections.Generic;
using System.Text;

namespace Bitebox.Models
{
    internal class Akun
    {
        private int _idAkun;
        private string _username;
        private string _password;
        private string _namaLengkap;
        private string _email;
        private string _role;

        public int IdAkun { get { return _idAkun; } set { _idAkun = value; } }
        public string Username { get { return _username; } set { _username = value; } }
        public string Password { get { return _password; } set { _password = value; } }
        public string NamaLengkap { get { return _namaLengkap; } set { _namaLengkap = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Role { get { return _role; } set { _role = value; } }

        public Akun() { }

        public Akun(int idAkun, string username, string namaLengkap, string email, string role)
        {
            _idAkun = idAkun;
            _username = username;
            _namaLengkap = namaLengkap;
            _email = email;
            _role = role;
        }
    }
}

