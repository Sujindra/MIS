using BIIS.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIIS.BusinessLogics
{
    public class BaseDAL
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString; 
        
        public static void showDashboard()
        {
            var dashboard = new Dashboard();
            dashboard.Show();
        }       
    }
}
