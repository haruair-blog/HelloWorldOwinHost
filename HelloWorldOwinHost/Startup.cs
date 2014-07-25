using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly:OwinStartup("ProductionConfiguration", typeof(HelloWorldOwinHost.Startup))]
[assembly:OwinStartup("DevelopmentConfiguration", typeof(HelloWorldOwinHost.StartupDev))]

namespace HelloWorldOwinHost
{
	public class Startup
	{
		public void Configuration (IAppBuilder app)
		{
			app.Use (typeof(MyMiddleWare));
			app.Run (context => {
				return context.Response.WriteAsync("<h1>HelloWorld</h1>");
			});
		}
	}

	public class StartupDev
	{
		public void Configuration (IAppBuilder app)
		{
			app.Use (typeof(MyMiddleWare));
			app.Run (context => {
				return context.Response.WriteAsync("<h1>HelloWorld Dev</h1>");
			});
		}
	}

	public class MyMiddleWare : OwinMiddleware
	{
		public MyMiddleWare(OwinMiddleware next) : base(next)
		{
		}

		public override async Task Invoke(IOwinContext context)
		{
			context.Response.Write ("<body>");
			await Next.Invoke (context);
			context.Response.Write ("</body>");
		}
	}
}

