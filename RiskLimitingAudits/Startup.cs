using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;

namespace RiskLimitingAudits
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDefaultFiles();
            app.UseStaticFiles();
        }
    }
}
