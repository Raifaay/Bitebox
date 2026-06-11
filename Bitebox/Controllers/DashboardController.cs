using Bitebox.Models.Context;
using Bitebox.Models.Entity; 
using System;
using System.Collections.Generic;
using System.Text;

namespace Bitebox.Controllers
{
    public class DashboardController
    {
        private readonly DashboardContext _dashboardContext;

        public DashboardController()
        {
            _dashboardContext = new DashboardContext();
        }

        public DashboardStats GetDashboardData()
        {
            return _dashboardContext.GetDashboardStatsData();
        }
    

    public int GetTotalJualByTanggal(DateTime tanggal)
        {
            return 0;
        }

        public long GetTotalPenghasilanByTanggal(DateTime tanggal)
        {
            return 0;
        }
    }
}
