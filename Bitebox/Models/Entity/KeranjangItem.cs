using System;
using System.Collections.Generic;
using System.Text;

namespace Bitebox.Models.Entity
{
    public class KeranjangItem
    {
        public int IdMenu { get; set; }
        public string NamaMenu { get; set; } = string.Empty;
        public decimal HargaMenu { get; set; }
        public int Jumlah { get; set; }
        public int IdAkun { get; set; }

        public decimal Subtotal => HargaMenu * Jumlah;
    }
}
