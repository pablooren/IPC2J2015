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
    public partial class AdminMasiva : System.Web.UI.Page
    {
        private ServiceReference1.WebService1SoapClient referencia = new ServiceReference1.WebService1SoapClient();
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
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
                    if (FileUpload1.FileName.ToLower() == "impuestos.csv") {
                        MessageBox.Show("son impuestos");
                        car.Impuesto(savePath);
                    } else if(FileUpload1.FileName.ToLower() == "empleados.csv"){
                    MessageBox.Show("son empleados");
                        car.Empleado(savePath, "Administrador");
                    }

                }

            }



        }
    }
}