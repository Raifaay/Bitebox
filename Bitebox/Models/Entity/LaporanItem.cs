using System;
using System.Collections.Generic;
using System.Text;

namespace Bitebox.Models.Entity
{
    public class LaporanItem
    { // INI Sma juga
        public string NamaMenu { get; set; } = "";
        public string Kategori { get; set; } = "";
        public int JumlahTerjual { get; set; }
        public int TotalPendapat { get; set; }
    }
}
