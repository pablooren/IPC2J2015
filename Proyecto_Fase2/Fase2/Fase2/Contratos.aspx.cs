using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;


namespace Fase2
{
    public partial class Contratos : System.Web.UI.Page
    {
        private ServiceReference1.WebService1SoapClient referencia = new ServiceReference1.WebService1SoapClient();
        logeado log = new logeado();
        String regis = "";
        protected void Page_Load(object sender, EventArgs e)
        {
           regis = referencia.Consulta1("Planilla ", "Departamento", "Nombre_usuario", "'" + log.user() + "'");
      //      regis = "1";
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            bool fileok = false;
            String savePath = @"";
            if (FileUpload1.HasFile)
            {
                String fileextension = System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
                if (fileextension == ".csv")
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
                    Carga_masiva car = new Carga_masiva();
                    car.Empleado(savePath, regis);

                }

            }
            else
            {

                bool exito = false;
                string datos = id.Text + ",'" + nom.Text + "','" + ape.Text + "'," + dpi.Text + "," + tele.Text + ",'" + domi.Text + "'";
                exito = referencia.Ingresar("Empleado", "ID_empleado,Nombre,Apellido,DPI,Telefono,Domicilio", datos);
                if (exito)
                {
                    // lo hiimos perro
                    bool exito2 = false;
                    String datos2 = id.Text + "," + regis + ",'" + cargo.SelectedItem.Text + "'," + sueldo.Text + ",'" + user.Text + "','" + pass.Text + "'";
                    exito2 = referencia.Ingresar("Planilla", "ID_empleado,Departamento,Cargo,Sueldo,Nombre_usuario,Contraseña", datos2);
                    if (exito2)
                    {
                        // perro
                        MessageBox.Show("el empleado se registro con exito");
                        Response.Redirect("Contratos.aspx");

                    }
                    else
                    {
                        // en la mierda
                        MessageBox.Show("porfavor verifica los datos");
                    }


                }
                else
                {
                    MessageBox.Show("no se pudo registrar empleado");
                }
            }

        }
    }
}