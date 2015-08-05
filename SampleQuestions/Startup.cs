using Microsoft.Owin;
using Owin;
using SampleQuestions;

[assembly: OwinStartup(typeof(Startup))]

namespace SampleQuestions
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseNancy();
        }
    }
}
