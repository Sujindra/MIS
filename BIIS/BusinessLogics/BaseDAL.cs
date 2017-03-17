using BIIS.Views;
using System.Configuration;

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
