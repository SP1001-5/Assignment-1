using ReportGenerator.Factories;
using ReportGenerator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select report type: Chart / Tabular / Summary");
            string choice = Console.ReadLine();

            ReportFactory factory = null;

            switch (choice.ToLower())
            {
                case "chart":
                    factory = new ChartReportFactory();
                    break;
                case "tabular":
                    factory = new TabularReportFactory();
                    break;
                case "summary":
                    factory = new SummaryReportFactory();
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    return;
            }

            IReportGenerator reportGenerator = factory.CreateReportGenerator();
            reportGenerator.GenerateReport();
        }
    }
}
