using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Collections;
namespace Fase2
{
    public class Facturas
    {
        private ServiceReference1.WebService1SoapClient referencia = new ServiceReference1.WebService1SoapClient();
     
        public void GenerarFactura(String fact) {
            Document factura = new Document(PageSize.LETTER);
            int cod = 1;
            String fa = "Factura1";
            String fi = "~/GFacturas/Factura1.pdf";
            bool no = false;
           while(no == false) {
                fa = "Factura1";
               if (File.Exists("~/GFacturas/" + fa + ".pdf"))
               {
                   fa = fa + cod.ToString();
                   cod++;
               }
               else {
                   no = true;
               }

            }
            PdfWriter writer = PdfWriter.GetInstance(factura, new FileStream("C:/Users/Pablo/Desktop/IPCJ2015/IPC2J2015/Proyecto_Fase2/Fase2/Fase2/"+fa+".pdf", FileMode.Create));
            factura.AddTitle("Quetzal Express");
            factura.AddAuthor("Pablo Orellana");
            factura.Open();
            factura.Add(new Paragraph("             Quetzal Express             "));
            
            String nombre = referencia.Consulta1("Factura f,Cliente c", "c.Nombre", "f.Cliente = c.DPI AND f.Orden ", fact);
            String apelli = referencia.Consulta1("Factura f,Cliente c", "c.Apellido", "f.Cliente = c.DPI AND f.Orden ", fact);
            String nit = referencia.Consulta1("Factura f,Cliente c", "c.NIT", "f.Cliente = c.DPI AND f.Orden ", fact);
            String dir = referencia.Consulta1("Factura f,Cliente c", "c.Direccion_domiciliar", "f.Cliente = c.DPI AND f.Orden ", fact);
            String casi = referencia.Consulta1("Factura f,Cliente c", "c.Cas_Int", "f.Cliente = c.DPI AND f.Orden ", fact);
            factura.Add(new Paragraph("             Guatemala,Jalapa             "));
            factura.Add(new Paragraph(""));
            factura.Add(new Paragraph("Nombre: "+nombre+" "+apelli));
            factura.Add(new Paragraph("  Casilla Internacional: "+casi));
            factura.Add(new Paragraph(""));
            factura.Add(new Paragraph(""));
            factura.Add(new Paragraph("Direccion"+ dir));
            factura.Add(new Paragraph(""));
            factura.Add(new Paragraph("NIT : "+nit));
            factura.Add(new Paragraph(""));
            factura.Add(new Paragraph("Factura No :" +fact));
            factura.Add(new Paragraph(""));
            int total = 0;
            ArrayList historiales = new ArrayList(referencia.Consulta("Factura f, Detalle_factura d", "d.Paquete, d.Total_parcial   ", "f.Orden = d.Factura AND f.Orden = "+fact, " "));
            foreach (String historial in historiales) {
                String[] linea = historial.Split(' ');
                factura.Add(new Paragraph(linea[0]+"               "+linea[1]));
                factura.Add(new Paragraph(""));
                total = total + Convert.ToInt32(linea[1]);

            }
            factura.Add(new Paragraph("TOTAL DE FACTURA                   "+total.ToString()));
            factura.Add(new Paragraph(""));
            factura.Add(new Paragraph("__________________________________________________________"));
            referencia.Update("Factura", "Total", total.ToString(), "Orden", fact);

            factura.Close();
            writer.Close();


        }

    }
}