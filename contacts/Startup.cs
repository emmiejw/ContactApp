using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(contacts.Startup))]
namespace contacts
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
