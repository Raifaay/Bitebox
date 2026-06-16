using System.Collections.Generic;
using Bitebox.Models.Context;

namespace Bitebox.Controllers
{
    internal class PesananControllerAdmin
    {
        private PesananContext _context = new PesananContext();

        public List<dynamic> GetPesananHariIni(string? filterStatus = null)
            => _context.GetPesananHariIni(filterStatus);

        public int GetTotal() => _context.GetTotalHariIni();
        public int GetCountByStatus(string status) => _context.GetCountByStatus(status);
        public bool UpdateStatus(int idPesanan, int idStatus) => _context.UpdateStatusPesanan(idPesanan, idStatus);
    }
}