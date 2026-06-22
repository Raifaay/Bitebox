using System;
using System.Collections.Generic;
using System.Text;

namespace Bitebox.Models.Entity
{
    internal class Pesanan
    {
        private int idPesanan;
        private DateTime tanggalPesanan;
        private int idAkun;
        private int idStatusPesanan;
        private int idStatusPembayaran;

        public int IdPesanan
        {
            get { return idPesanan; }
            set { idPesanan = value; }
        }
        public DateTime TanggalPesanan
        {
            get { return tanggalPesanan; }
            set { tanggalPesanan = value; }
        }
        public int IdAkun
        {
            get { return idAkun; }
            set { idAkun = value; }
        }
        public int IdStatusPesanan
        {
            get { return idStatusPesanan; }
            set { idStatusPesanan = value; }
        }
        public int IdStatusPembayaran
        {
            get { return idStatusPembayaran; }
            set { idStatusPembayaran = value; }
        }

        public Pesanan() { }

        public Pesanan(int idPesanan, DateTime tanggalPesanan, int idAkun, int idStatusPesanan, int idStatusPembayaran)
        {
            this.idPesanan = idPesanan;
            this.tanggalPesanan = tanggalPesanan;
            this.idAkun = idAkun;
            this.idStatusPesanan = idStatusPesanan;
            this.idStatusPembayaran = idStatusPembayaran;
        }

        public virtual void Proses() // ini juga kalo misalnya ini ga ada mending override aja daripa pake abst
        {
        }
    }
}
