using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularWebApiRestaurantSearch.Startup))]
namespace AngularWebApiRestaurantSearch
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
