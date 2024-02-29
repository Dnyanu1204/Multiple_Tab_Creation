using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using Multiple_Tab_Creation.MyCommand;
using System.Linq;
using System.Windows.Input;
namespace Multiple_Tab_Creation.ViewModel
{
    class AboutViewModel:BaseViewModel
    {
        public string name ="About";

        private static string GetCellValue(WorkbookPart workbookPart, Cell cell)
        {
            SharedStringTablePart sharedStringTablePart = workbookPart.SharedStringTablePart;
            if (cell.DataType != null && cell.DataType.Value == CellValues.SharedString)
            {
                int index = int.Parse(cell.InnerText);
                return sharedStringTablePart.SharedStringTable.Elements<SharedStringItem>().ElementAt(index).InnerText;
            }
            else
            {
                return cell.InnerText;
            }
        }
        public void ReadData()
        {
            string filePath = "D:/TOYO WORK/Support_Structure_Load_Data.xlsx";
            using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Open(filePath, false))
            {
                //WorkbookPart Represents the main part of an Excel workbook.including sheets (worksheets), styles, shared strings, and other relevant data
                WorkbookPart workbookPart = spreadsheetDocument.WorkbookPart;
                //is property provides access to all the worksheet parts associated with the workbook.
                WorksheetPart worksheetPart = workbookPart.WorksheetParts.First();
                //The SheetData element represents the actual data (rows and cells) within an Excel worksheet.
                SheetData sheetData = worksheetPart.Worksheet.Elements<SheetData>().Last();

                //Searches through the elements in the collection.Returns the first element that satisfies the condition.
                Cell cellA1 = sheetData.Elements<Row>().FirstOrDefault()?.Elements<Cell>().FirstOrDefault();
                if (cellA1 != null)
                {
                    string cellValue = GetCellValue(workbookPart, cellA1);

                    System.Windows.MessageBox.Show($"Value in A1: {cellValue}");
                }

            }


        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public ICommand GetDataCommand
        {
            get
            {
                return new Mycommand(ReadData);
            }
        }

    }
}
