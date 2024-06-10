using OfficeOpenXml;
using OfficeOpenXml.Packaging.Ionic.Zip;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdkpractice
{
    internal class GenerateExcelPackage
    {
        public byte[] Generate(MarketReport report)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var package = new ExcelPackage();

            string filename = "C:\\Users\\oval19\\Desktop\\TestReport\\Отчет.Xlsx";

            var sheet = package.Workbook.Worksheets.Add("Отчет");

            if (File.Exists("C:\\Users\\oval19\\Desktop\\TestReport\\Отчет.Xlsx") == true)
            {
                Console.WriteLine("Отчет Создан");
            }
            else
            {
                Console.WriteLine("Ошибка создания файла");
            }
            //Ввод данных в ячейки
            sheet.Cells["B2"].Value = "Цех:";
            sheet.Cells[2, 3].Value = report.Workshop.ShopName;
            sheet.Cells["B3"].Value = "Sector";
            sheet.Cells["C3"].Value = report.Workshop.Sector;
            sheet.Cells["E2"].Value = "Дата начала отчета";
            sheet.Cells["F2"].Value = report.Workshop.StartDate;
            sheet.Cells["E3"].Value = "Выберите дату отчета";
            sheet.Cells["F3"].Value = report.Workshop.EndDate;

            //Формат данных в ячейках
            sheet.Cells["F3,F2"].Style.Numberformat.Format = "yyy.mm.dd";
            sheet.Cells["C"].AutoFitColumns();
            sheet.Cells["F"].AutoFitColumns();
            sheet.Cells["E"].AutoFitColumns();
            return package.GetAsByteArray();
        }

    }
}
