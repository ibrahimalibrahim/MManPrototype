using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReader
{
    class DataExtractor
    {
        XSSFWorkbook wb;
        XSSFSheet sh;
        
        public List<Item> ExtractItems(BackgroundWorker worker)
        {
            using (var fs = new FileStream("Data.xlsx", FileMode.Open, FileAccess.Read))
            {
                wb = new XSSFWorkbook(fs);
                sh = (XSSFSheet)wb.GetSheet(wb.GetSheetAt(0).SheetName);
                int i = 1;
                List<Item> items = new List<Item>();
                
                while (sh.GetRow(i) != null)
                {
                    Item item = new Item()
                    {
                        Category = sh.GetRow(i).GetCell(0).StringCellValue,
                        Name = sh.GetRow(i).GetCell(1).StringCellValue,
                        Code = sh.GetRow(i).GetCell(2).NumericCellValue.ToString(),
                        Unit = sh.GetRow(i).GetCell(3).StringCellValue,
                        Cost = sh.GetRow(i).GetCell(4).NumericCellValue
                    };
                    items.Add(item);
                    worker.ReportProgress(Math.Min(i, 99), i.ToString() + ": " + item.Name);

                    i++;
                }
                worker.ReportProgress(100,"");

                return items;
            }

        }
        
        
    }
}
