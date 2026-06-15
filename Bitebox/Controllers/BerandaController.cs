using Bitebox.Models.Context;
using Bitebox.Models.Entity;

namespace Bitebox.Controllers
{
    public class BerandaController
    {
        private readonly BerandaContext _dashboardContext;

        public BerandaController()
        {
            _dashboardContext = new BerandaContext();
        }

        public Beranda GetDashboardData()
        {
            return _dashboardContext.GetDashboardStatsData();
        }
    }
}