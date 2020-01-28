using Nancy;
using Nancy.Configuration;
using Nancy.TinyIoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        //private readonly IAppConfiguration appConfig;

        public Bootstrapper()
        {
        }

        //public DemoBootstrapper(IAppConfiguration appConfig)
        //{
        //    this.appConfig = appConfig;
        //}
        public override void Configure(INancyEnvironment environment)
        {
            var config = new TraceConfiguration(enabled: false, displayErrorTraces: true);
            environment.AddValue(config);
        }
        protected override void ConfigureApplicationContainer(TinyIoCContainer container)
        {
            base.ConfigureApplicationContainer(container);
            //container.Register<IAppConfiguration>(appConfig);
        }
    }
}
