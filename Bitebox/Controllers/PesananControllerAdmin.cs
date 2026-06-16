using Bitebox.Models.Context;
using System;
using System.Collections.Generic;

namespace Bitebox.Controllers
{
    public class PesananControllerAdmin
    {
        private readonly PesananContext _pesananContext = new PesananContext();

        public List<dynamic> GetPesananHariIni(string filterStatus)
        {
            return _pesananContext.GetPesananHariIni(filterStatus ?? "");
        }

        public int GetCountByStatus(string status)
        {
            try
            {
                var list = _pesananContext.GetPesananHariIni("");
                int count = 0;
                foreach (var p in list)
                {
                    if (p.StatusPesanan == status) count++;
                }
                return count;
            }
            catch (Exception) { return 0; }
        }

        public decimal GetTotal()
        {
            try
            {
                var list = _pesananContext.GetPesananHariIni("");
                decimal total = 0;
                foreach (var p in list)
                {
                    total += Convert.ToDecimal(p.Total);
                }
                return total;
            }
            catch (Exception) { return 0; }
        }

        public bool UpdateStatus(int idPesanan, int idStatus)
        {
            return _pesananContext.UpdateStatusPesanan(idPesanan, idStatus);
        }
    }
}