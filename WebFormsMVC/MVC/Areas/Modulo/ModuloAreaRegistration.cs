using System.Web.Mvc;

namespace MVC.Areas.Modulo
{
    public class ModuloAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Modulo";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Modulo_default",
                "Modulo/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }, new object[] { "MVC.Areas.Modulo.Controllers" }
            );
        }
    }
}
