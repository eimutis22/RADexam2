using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RAD_Exam_2.Startup))]
namespace RAD_Exam_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
