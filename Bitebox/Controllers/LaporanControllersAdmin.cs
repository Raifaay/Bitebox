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
        private readonly LaporanContextAdmin _context = new LaporanContextAdmin();

        public int GetTotalPenjualan(string periode = "bulan") => _context.GetTotalPenjualan(periode);
        public int GetTotalTransaksi(string periode = "bulan") => _context.GetTotalTransaksi(periode);
        public int GetRataRata(string periode = "bulan")
        {
            int totalTransaksi = _context.GetTotalTransaksi(periode);
            if (totalTransaksi == 0) return 0;
            return _context.GetTotalPenjualan(periode) / totalTransaksi;
        }
        public List<LaporanItem> GetLaporan(string periode = "bulan", string? filterKategori = null)
            => _context.GetLaporan(periode, filterKategori);
        public List<LaporanRollup> GetLaporanRollup(string periode = "bulan")
            => _context.GetLaporanRollup(periode);
        public List<string> GetSemuaKategori() => _context.GetSemuaKategori();
    }
}