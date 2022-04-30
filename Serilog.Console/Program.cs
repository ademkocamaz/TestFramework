using Serilog.Formatting.Compact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serilog.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .WriteTo.Console()
            .WriteTo.File(new CompactJsonFormatter(), "log.json",
                rollingInterval: RollingInterval.Day,
                rollOnFileSizeLimit: true)
            //.WriteTo.File("log.txt",
            //    rollingInterval: RollingInterval.Day,
            //    rollOnFileSizeLimit: true)
            .CreateLogger();

            Log.Information("Hello, Serilog!");


            try
            {
                throw new Exception();
            }
            catch (Exception exception)
            {

                Log.Error(exception, "Hata oluştu.");
            }

            Log.CloseAndFlush();
            System.Console.ReadKey();
        }
    }
}
