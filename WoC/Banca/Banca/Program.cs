using BazaDate;
using log4net;
using log4net.Config;
using LogicaBanca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Banca
{
    static class Program
    {
        static ILog log;

        static Program()
        {
            XmlConfigurator.Configure();
            log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
            log.Info($"App Banca started {Environment.UserDomainName}.{Environment.UserName}");
        }

        static void Main(string[] args)
        {
            //TODO:
            // nuget package
            // ref si out
            // setup TFS
            Date db = Date.LoadData<Date>(nameof(Date));




            log.Info($"Main: App Banca stopped {Environment.UserDomainName}.{Environment.UserName}");
        }
    }
}
