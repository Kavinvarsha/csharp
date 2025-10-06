using System;
class TextPrinter{
    public void PrintText(string text){
        Console.WriteLine("Printing Text: " + text);
    }
}
class PdfPrinterAdapter{
    private TextPrinter printer = new TextPrinter();
    public void PrintPdf(string pdf){
        printer.PrintText("PDF Content: " + pdf);
    }
}
class Program{
    static void Main(){
        PdfPrinterAdapter pdfAdapter = new PdfPrinterAdapter();
        pdfAdapter.PrintPdf("MyDocument.pdf");
    }
}
