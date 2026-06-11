using System;
using System.Collections.Generic;
using System.Text;

namespace Bitebox.Models.Entity
{
    public class AkunModel
    {
        public int IdAkun { get; set; }
        public string Username { get; set; }
        public string NamaLengkap { get; set; }
        public string Email { get; set; }
        public bool IsAktif { get; set; }

    }
}
