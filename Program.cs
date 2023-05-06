using Spire.Pdf;
using Spire.Pdf.Graphics;
using System.Drawing.Imaging;

public class PdfToImageConverter
{
    public void ConvertPdfToImage(string pdfFilePath, string outputFilePath)
    {
        using (var pdfDocument = new PdfDocument())
        {
            pdfDocument.LoadFromFile(pdfFilePath);

            for (int pageIndex = 0; pageIndex < pdfDocument.Pages.Count; pageIndex++)
            {
                using (var pageImage = pdfDocument.SaveAsImage(pageIndex, PdfImageType.Bitmap, 300, 300))
                {
                    pageImage.Save($"{outputFilePath}\\archivo_{pageIndex}.png", ImageFormat.Png);
                }
            }
        }
    }
}
