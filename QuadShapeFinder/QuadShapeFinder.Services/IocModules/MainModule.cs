using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Serilog;
using System.Configuration;
using QuadShapeFinder.Services.Infrastructure;

namespace QuadShapeFinder.Services.IocModules
{
    public class MainModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            var logFilePath = ConfigurationManager.AppSettings["LogFilePath"];

            builder.Register(o => new ConfigSettingProvider()).As<IConfigSettingProvider>();

            builder.Register(c => new LoggerConfiguration()
                .WriteTo.File(logFilePath)
                .CreateLogger()).
                As<ILogger>().SingleInstance();
        }
    }
}
