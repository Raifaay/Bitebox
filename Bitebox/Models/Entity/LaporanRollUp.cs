using System;
using System.Collections.Generic;
using System.Text;

namespace Bitebox.Models.Entity
{
    internal class LaporanRollup
    { // get setter nya
        public string Kategori { get; set; } = string.Empty;
        public string NamaMenu { get; set; } = string.Empty;
        public int JumlahTerjual { get; set; }
        public int TotalPendapat { get; set; } // ini gausah karena bagian ini tuh memang butuh minus
    }
}
