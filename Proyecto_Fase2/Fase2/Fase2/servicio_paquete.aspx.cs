using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Fase2
{
    public partial class servicio_paquete : System.Web.UI.Page
    {
        Servicio_al_cliente serv = new Servicio_al_cliente();
        private ServiceReference1.WebService1SoapClient referencia = new ServiceReference1.WebService1SoapClient();
       private static  bool fact = false;
       private static String facura = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            String aux1 = "";
            aux1 = serv.GetCas();
            if (aux1 != "")
            {
                casi_label.Text ="Casilla Internacional :"+ aux1;
                Nombre_label.Text = referencia.Consulta1("Cliente c", "c.DPI", "c.Cas_Int", aux1);

            }
            else {
                casi_label.Text = "1";
                Nombre_label.Text = "N/A";
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (GridView1.SelectedRow == null)
            {
                MessageBox.Show("Porfavor seleccione un paquete");

            }
            else {
                if (DropDownList1.SelectedItem.Text == "Facturar") { 
                // Aqui toda la logica para facturar
                    String aux1 = referencia.Consulta1("Factura f, Cliente c", "f.Orden", "f.Estado = 'Facturando' AND f.Cliente = c.DPI AND c.DPI", Nombre_label.Text);
                    if (aux1 == "")
                    {
                        // creamos factura
                        GridViewRow row = GridView1.SelectedRow;
                        String aux2 = referencia.Consulta1("Paquete p", "p.Destino", "p.ID_paquete", row.Cells[1].Text);
                        if (referencia.Ingresar("Factura", "Sucursal,Cliente,Total,Estado", aux2 + "," + Nombre_label.Text + ",00,'Facturando'"))
                        {
                            MessageBox.Show("Factura creada con exito");

                            String aux3 = referencia.Consulta1("Factura f", "f.Orden", "f.Estado ='Facturando' AND f.Sucursal = " + aux2 + " AND f.Cliente ", Nombre_label.Text);
                            facura = aux3;
                            int pes = Convert.ToInt32(referencia.Consulta1("Paquete p", "p.Peso_lb", "p.ID_paquete", row.Cells[1].Text));
                            int prec = Convert.ToInt32(referencia.Consulta1("Paquete p", "p.Precio", "p.ID_paquete", row.Cells[1].Text));
                            int comipeso = Convert.ToInt32(referencia.Consulta1("Impuesto i", "i.Porcentaje", "i.Nombre ", "'Pesos'"));
                            int comiemp = Convert.ToInt32(referencia.Consulta1("Impuesto i", "i.Porcentaje", "i.Nombre ", "'Comision'"));
                            int imp = Convert.ToInt32(referencia.Consulta1("Paquete p, Impuesto i", "i.Porcentaje", "p.Categoria = i.Serie_imp AND p.ID_paquete ", row.Cells[1].Text));
                            String det = referencia.Consulta1("Paquete p, Impuesto i", "i.Nombre", "p.Categoria = i.Serie_imp AND p.ID_paquete ", row.Cells[1].Text);
                            float total = ((pes * comipeso) + (prec * imp / 100)) * comiemp / 100;
                            total = total + ((pes * comipeso) + (prec * imp / 100));

                            if (referencia.Ingresar("Detalle_factura", "Cliente,Factura,Paquete,Total_parcial", Nombre_label.Text + "," + aux3 + ",'" + det + "'," + total.ToString()))
                            {
                                MessageBox.Show("Detalle creado");
                                referencia.Update("Paquete", "Estado", "'Facturado'", "ID_paquete", row.Cells[1].Text);
                                referencia.Update("Historial", "Fecha_Facturado", "GETDATE()", "Paquete", row.Cells[1].Text);
                                Response.Redirect("servicio_paquete.aspx");
                                fact = true;
                            }
                        }

                    }
                    else {
                        GridViewRow row = GridView1.SelectedRow;
                        String aux2 = referencia.Consulta1("Paquete p", "p.Destino", "p.ID_paquete", row.Cells[1].Text);
                        String aux3 = referencia.Consulta1("Factura f", "f.Orden", "f.Estado ='Facturando' AND f.Sucursal = " + aux2 + " AND f.Cliente ", Nombre_label.Text);
                        int pes = Convert.ToInt32(referencia.Consulta1("Paquete p", "p.Peso_lb", "p.ID_paquete", row.Cells[1].Text));
                        int prec = Convert.ToInt32(referencia.Consulta1("Paquete p", "p.Precio", "p.ID_paquete", row.Cells[1].Text));
                        int comipeso = Convert.ToInt32(referencia.Consulta1("Impuesto i", "i.Porcentaje", "i.Nombre ", "'Pesos'"));
                        int comiemp = Convert.ToInt32(referencia.Consulta1("Impuesto i", "i.Porcentaje", "i.Nombre ", "'Comision'"));
                        int imp = Convert.ToInt32(referencia.Consulta1("Paquete p, Impuesto i", "i.Porcentaje", "p.Categoria = i.Serie_imp AND p.ID_paquete ", row.Cells[1].Text));
                        String det = referencia.Consulta1("Paquete p, Impuesto i", "i.Nombre", "p.Categoria = i.Serie_imp AND p.ID_paquete ", row.Cells[1].Text);
                        float total = ((pes * comipeso) + (prec * imp / 100)) * comiemp / 100;
                        total = total + ((pes * comipeso) + (prec * imp / 100));

                        if (referencia.Ingresar("Detalle_factura", "Cliente,Factura,Paquete,Total_parcial", Nombre_label.Text + "," + aux3 + ",'" + det + "'," + total.ToString()))
                        {
                            MessageBox.Show("Detalle creado");
                            referencia.Update("Paquete", "Estado", "'Facturado'", "ID_paquete", row.Cells[1].Text);
                            referencia.Update("Historial", "Fecha_Facturado", "GETDATE()", "Paquete", row.Cells[1].Text);
                            Response.Redirect("servicio_paquete.aspx");
                            
                        }
                    
                    
                    }



                }
                else if (DropDownList1.SelectedItem.Text == "Devolver") {
                    GridViewRow row = GridView1.SelectedRow;
                    if (referencia.Update("Paquete", "Estado", "'Devuelto'", "  ID_paquete", row.Cells[1].Text)) {
                        MessageBox.Show("El paquete se devolvera");
                        Response.Redirect("servicio_paquete.aspx");
                    }
                    

                
                }
                else if (DropDownList1.SelectedItem.Text == "Imprimir") {
                //    if (fact == false)
                  //  {
                    //    MessageBox.Show("Porfavor seleccione paquetes para imprimir factura");
                  //  }
                 //   else
                 //   {
                        Facturas factu = new Facturas();
                        factu.GenerarFactura(facura);
                        referencia.Update("Factura", "Estado", "'Facturado'", "Orden", facura);
                        Response.Redirect("servicio_paquete.aspx");
                        fact = false;


                   // }

                }
            
            }


        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}