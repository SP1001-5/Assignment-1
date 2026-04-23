using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge_4
{

    interface IReportGenerator
    {
        void GenerateReport();
    }

    class ChartReportGenerator : IReportGenerator
    {
        public void GenerateReport()
        {
            Console.WriteLine("Generating Chart Report...");
        }
    }

    class TabularReportGenerator : IReportGenerator
    {
        public void GenerateReport()
        {
            Console.WriteLine("Generating Tabular Report...");
        }
    }

    class SummaryReportGenerator : IReportGenerator
    {
        public void GenerateReport()
        {
            Console.WriteLine("Generating Summary Report...");
        }
    }

    abstract class ReportFactory
    {
        public abstract IReportGenerator CreateReportGenerator();
    }

    class ChartReportFactory : ReportFactory
    {
        public override IReportGenerator CreateReportGenerator()
        {
            return new ChartReportGenerator();
        }
    }

    class TabularReportFactory : ReportFactory
    {
        public override IReportGenerator CreateReportGenerator()
        {
            return new TabularReportGenerator();
        }
    }

    class SummaryReportFactory : ReportFactory
    {
        public override IReportGenerator CreateReportGenerator()
        {
            return new SummaryReportGenerator();
        }
    }
    internal class Report_Generator
    {
        public static void main()
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
        }
    }
}
