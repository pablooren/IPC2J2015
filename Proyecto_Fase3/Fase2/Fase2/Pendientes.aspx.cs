using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Fase2
{
    public partial class Pendientes1 : System.Web.UI.Page
    {
        private ServiceReference1.WebService1SoapClient referencia = new ServiceReference1.WebService1SoapClient();
        logeado log = new logeado();
        protected void Page_Load(object sender, EventArgs e)
        {
           cascas.Text = referencia.Consulta1("Cliente c", "c.DPI", "c.Nombre_usuario", "'" + log.user() + "'");



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
             bool fileok = false;
            String savePath = @"";
            if (FileUpload1.HasFile)
            {
                String fileextension = System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
                if ( fileextension == ".jpg" || fileextension == ".png")
                {
                    fileok = true;
                    savePath = @"C:\Users\Public\";
                    String fileName = FileUpload1.FileName;
                    savePath += fileName;
                    if (File.Exists(savePath))
                    {
                        File.Delete(savePath);
                    }
                    FileUpload1.SaveAs(savePath);
                }
                else
                {
                    MessageBox.Show("La extension del archivo es incorrecta");
                }
                if (fileok)
                {
                    
                    GridViewRow row = GridView1.SelectedRow;
                    

                            System.IO.MemoryStream ms = new System.IO.MemoryStream();
                            System.Drawing.Image img = System.Drawing.Image.FromFile(savePath);
                            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);


                            if (referencia.Update("Paquete", "Imagen", "(SELECT * FROM OPENROWSET(BULK N'" + savePath + "', SINGLE_BLOB) AS CategoryImage)", "ID_paquete", row.Cells[1].Text))

                            {
                                MessageBox.Show("Paquete modificado con exito");
                                referencia.Update("Paquete", "Estado", "'En espera'", "ID_paquete", row.Cells[1].Text);

                                  Response.Redirect("Pendientes.aspx");
                            }
                            else
                            {
                                MessageBox.Show("Hay un error, porfavor verifica los campos");
                            }

                        }
                    
                    
                    
                    
                }
        }
    }
}