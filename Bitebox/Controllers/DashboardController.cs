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
    }
}
