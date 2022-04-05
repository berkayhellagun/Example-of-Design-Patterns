using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Example2
{
    public class Report
    {
        IReportFormat _format;
        public Report(IReportFormat format)
        {
            _format = format;
        }
        public virtual void Display()
        {
            _format.Generate();
        }
    }
    public class SalesReport : Report
    {
        public SalesReport(IReportFormat format) : base(format)
        {

        }
        public override void Display()
        {
            Console.WriteLine("satış raporu");
            base.Display();
        }
    }
    public class EmpoyeePerformanceReport : Report
    {
        public EmpoyeePerformanceReport(IReportFormat format) : base(format)
        {

        }
        public override void Display()
        {
            Console.WriteLine("çalışan performansı");
            base.Display();
        }
    }

    public interface IReportFormat
    {
        void Generate();
    }
    public class DesktopFormat : IReportFormat
    {
        public void Generate()
        {
            Console.WriteLine("Masaüstüne yazıldı.");
        }
    }
    public class WebFormat : IReportFormat
    {
        public void Generate()
        {
            Console.WriteLine("Web'e yazıldı");
        }
    }
}
