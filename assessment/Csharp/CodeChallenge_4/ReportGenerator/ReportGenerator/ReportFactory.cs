using ReportGenerator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator
{
    public abstract class ReportFactory
    {
        public abstract IReportGenerator CreateReportGenerator();
    }
}
