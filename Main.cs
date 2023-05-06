using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDF_TO_IMG_CONVERTER
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convirtiendo cada página del pdf en una img");

            var pdfToImageConverter = new PdfToImageConverter();
            pdfToImageConverter.ConvertPdfToImage("C:\\prueba.pdf", "C:\\Users\\jhona\\Downloads\\");

            Console.WriteLine("Todas las páginas del pdf ahora son imgs y se guardaron en la ruta indicada");
            Console.ReadKey();
        }
    }
}
