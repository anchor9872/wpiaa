namespace launcher.c1;
using iText.Kernel.Pdf;
using System.Text;


public class InvoiceGenerator
{
    public void GenerateInvoice()
    {
        int invoiceNumber = 12345;
        PdfWriter pdfWriter = new PdfWriter($"Invoice_{invoiceNumber}.pdf");
        
        // Generowanie faktury
        byte[] byteArray = Encoding.UTF8.GetBytes("Invoice content");
        pdfWriter.Write(byteArray);
        pdfWriter.Close();
    }

    public void OtherMethod()
    {
        // Metoda, która nie korzysta z tymczasowych pól
    }
}