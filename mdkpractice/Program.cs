using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdkpractice
{
    internal static class Program
    {
        static void Main(string[] args)
        { 
            var reportData = new MakeReporter().GetReport();

            var reportExcel = new GenerateExcelPackage().Generate(reportData);
            string filename = "C:\\Users\\oval19\\Desktop\\TestReport\\Отчет.Xlsx";
            File.WriteAllBytes(filename, reportExcel);
        }
    }
    
}
