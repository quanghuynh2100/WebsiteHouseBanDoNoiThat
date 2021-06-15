using System.Web.Mvc;

namespace WebsiteHouseBanDoNoiThat.Areas.Administrator
{
    public class AdministratorAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Administrator";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Administrator_default",
                "Administrator/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] {"WebsiteHouseBanDoNoiThat.Areas.Administrator.Controllers"}
            );
        }
    }
}