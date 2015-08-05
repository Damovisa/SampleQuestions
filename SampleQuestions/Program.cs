using System;
using Microsoft.Owin.Hosting;

namespace SampleQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebApp.Start<Startup>("http://localhost:12345"))
            {
                Console.WriteLine("Started. Press Enter to quit.");
                Console.ReadLine();
            }

        }
    }
}
