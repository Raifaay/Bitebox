
using Bitebox.Models.Entity;
using Bitebox.Models.Context;
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
        public int Total { get; set; }
    }
}