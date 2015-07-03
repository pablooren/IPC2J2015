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
    public partial class Bodega : System.Web.UI.Page
    {
        String usuario = "";
        String suc = "";
        private ServiceReference1.WebService1SoapClient referencia = new ServiceReference1.WebService1SoapClient();
      
        protected void Page_Load(object sender, EventArgs e)
        {
            logeado log = new logeado();
            usuario = log.user();
            suc = referencia.Consulta1("Planilla p, Registro r , Sucursal s", "s.Direccion", "s.Serie_Suc = r.sede_id AND p.Departamento = r.no_registro AND p.Nombre_usuario", "'" + usuario + "'");
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
                    car.bodega(savePath, suc);
                }
            }
        }
    }
}