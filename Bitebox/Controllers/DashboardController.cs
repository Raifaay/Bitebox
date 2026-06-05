using Bitebox.Models.Context;
using Bitebox.Models.Entity; 
using System;
using System.Collections.Generic;
using System.Text;

namespace Bitebox.Controllers
{
    public class DashboardController
    {
        private readonly DashboadContext _dashboardContext; 

        public DashboardController()
        {
            _dashboardContext = new DashboadContext(); 
        }

        public DashboardStats GetDashboardData()
        {
            return _dashboardContext.GetDashboardStatsData();
        }
    }
}
