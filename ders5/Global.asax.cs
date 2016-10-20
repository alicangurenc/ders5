using ders5.Data;
using System.Web.Mvc;
using System.Web.Routing;

namespace ders5
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            dbContainer db = new dbContainer();
            db.Database.CreateIfNotExists();

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
