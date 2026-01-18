using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;
using System.Windows.Forms;

namespace P13_714240046
{
    class Excel
    {
        public void ExportToExcel(DataGridView dgv, string filePath)
        {
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                ExcelWorksheet worksheet =
                    excelPackage.Workbook.Worksheets.Add("Sheet1");

                // HEADER
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value =
                        dgv.Columns[i].HeaderText;

                    worksheet.Cells[1, i + 1].Style.Font.Bold = true;
                }

                // DATA
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value =
                            dgv.Rows[i].Cells[j].Value;
                    }
                }

                worksheet.Cells.AutoFitColumns();

                FileInfo file = new FileInfo(filePath);
                excelPackage.SaveAs(file);
            }
        }
    }
}
