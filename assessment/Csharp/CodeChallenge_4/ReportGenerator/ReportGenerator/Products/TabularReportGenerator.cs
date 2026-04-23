using ReportGenerator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator.Products
{
    public class TabularReportGenerator : IReportGenerator
    {
        public void GenerateReport()
        {
            Console.WriteLine("Generating Tabular Report...");
        }
    }
}
