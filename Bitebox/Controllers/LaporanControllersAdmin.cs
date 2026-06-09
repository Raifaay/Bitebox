using Bitebox.Helpers;
using Bitebox.Models.Context;
using Bitebox.Models.Entity;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;


namespace Bitebox.Controllers
{
    internal class LaporanControllersAdmin
    {
        private LaporanContextAdmin laporanContext = new LaporanContextAdmin();

        public int GetTotalPenjualan() => laporanContext.GetTotalPenjualan();

        public int GetTotalTransaksi() => laporanContext.GetTotalTransaksi();

        public int GetRataRata()
        {
            int totalTransaksi = laporanContext.GetTotalTransaksi();
            if (totalTransaksi == 0) return 0;
            return laporanContext.GetTotalPenjualan() / totalTransaksi;
        }

        public List<LaporanItem> GetLaporan(string? filterKategori = null)
        {
            return laporanContext.GetLaporan(filterKategori);
        }

        public List<string> GetSemuaKategori() => laporanContext.GetSemuaKategori();
    }
}
