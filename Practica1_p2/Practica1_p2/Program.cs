using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Practica1_p2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
//                UTM
//APLICACIONES WEB ORIENTADAS A SERVICIOS
//              Profesor: 
//          Ing. Joel Ivan Chuc
//Construir una API en base a un diseño
//              Elaboró:
//         Cauich Colli Rafael
//               4A DSM
//           Segundo parcial