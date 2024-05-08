using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BL
{
    public class BLpdf
    {

        public bool ExportPdf(DataGridView dataGrid)
        {
            try
            {
                PdfPTable pdfTable = new PdfPTable(dataGrid.ColumnCount);
                pdfTable.DefaultCell.Padding = 2;
                pdfTable.WidthPercentage = 100;
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfTable.DefaultCell.BorderWidth = 2;
                foreach (DataGridViewColumn column in dataGrid.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    pdfTable.AddCell(cell);
                }
                foreach (DataGridViewRow row in dataGrid.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfTable.AddCell(cell.Value.ToString());
                    }
                }
                string folderPath = string.Empty;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "PDF Files|*.pdf";
                saveFileDialog1.Title = "Save a Pdf File";
                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName != "")
                {
                    System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                    fs.Close();
                    folderPath = fs.Name;
                }
                using (FileStream stream = new FileStream(folderPath, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                }
                MessageBox.Show("PDF'e aktarma işlemi başarıyla gerçekleşmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (ArgumentException )
            {
                return false;
            }
            catch (Exception )
            {
                MessageBox.Show("PDF'e aktarma işlemi başarısız. Bilgileri kontrol edip tekrar deneyiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
