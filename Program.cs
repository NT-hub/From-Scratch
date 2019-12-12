using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace FromScratch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine("Hello World");
            /*
            Console.WriteLine("\nWhat is your name? ");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"\n Hello, {name}, on {date:t}!");
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey(true);
            */

            /*
            Creator youtuber = new Youtuber();
            Creator programmer = new Programmer();

            Console.WriteLine("--- Youtuber---");
            Console.WriteLine();
            youtuber.Create();


            Console.WriteLine("--- Programmer---");
            Console.WriteLine();
            programmer.Create();
            */

            // Change it to polymorphism way
            List<Creator> creators = new List<Creator>() { new Youtuber(), new Programmer()};

            foreach(var creator in creators)
            {
                Console.WriteLine(creator.GetType().Name);
                creator.Create();
                Console.WriteLine();
            }

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
