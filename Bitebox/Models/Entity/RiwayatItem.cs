using System;

namespace Bitebox.Models.Entity
{
    internal class RiwayatItem
    {
        public int IdPesanan { get; set; }
        public DateTime TanggalPesanan { get; set; }
        public string? KodePickup { get; set; }
        public string? NomorMeja { get; set; }
        public string NamaStatus { get; set; } = string.Empty;
        public string NamaStatusPembayaran { get; set; } = string.Empty;
        public string MetodePembayaran { get; set; } = string.Empty;
        public decimal Total { get; set; }
        public string JenisLayanan => KodePickup != null ? "Take Away" : $"Dine In - {NomorMeja}";
    }
}