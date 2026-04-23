using ReportGenerator.Interface;
using ReportGenerator.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator.Factories
{
    public class ChartReportFactory : ReportFactory
    {
        public override IReportGenerator CreateReportGenerator()
        {
            return new ChartReportGenerator();
        }
    }
}
