using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security.Cookies;
using Owin;

namespace UserIdentity.App_Start
{
    public class IdentityConfig
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath=new Microsoft.Owin.PathString("/Account/Login")
            });
        }
    }
}
