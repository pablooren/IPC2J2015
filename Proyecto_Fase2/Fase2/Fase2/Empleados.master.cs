using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fase2
{
    public partial class Empleados : System.Web.UI.MasterPage
    {
        public static String usuario1 = "";
        private ServiceReference1.WebService1SoapClient referencia = new ServiceReference1.WebService1SoapClient();
      
        protected void Page_Load(object sender, EventArgs e)
        {


            logeado lo = new logeado();
            nom.Text = lo.user();
            depto.Text = referencia.Consulta1("Planilla p, Registro r , Departamento d	", "d.Nombre", "d.Serie_dept = r.depto_id AND p.Departamento = r.no_registro AND p.Nombre_usuario", "'" + nom.Text + "'");
            suc.Text = referencia.Consulta1("Planilla p, Registro r , Sucursal s", "s.Direccion", "s.Serie_Suc = r.sede_id AND p.Departamento = r.no_registro AND p.Nombre_usuario", "'" + nom.Text + "'");
            pais.Text = referencia.Consulta1("Planilla p, Registro r , Sucursal s", "s.Pais", "s.Serie_Suc = r.sede_id AND p.Departamento = r.no_registro AND p.Nombre_usuario", "'" + nom.Text + "'");
       //     depto.Text = referencia.Consulta1("Planilla p , Registro r , Departamento d", "d.Nombre", " p.Departamento = r.no_registro AND d.Serie_dept = r.depto_id AND p.Nombre_usuario", "'" + nom.Text + "'");
       //     suc.Text = referencia.Consulta1("Planilla p , Registro r , Departamento d, Sucursal s", "s.Direccion", "p.Departamento = r.no_registro AND d.Serie_dept = r.depto_id AND S.Serie_Suc = R.sede_id AND p.Nombre_usuario", "'" + nom.Text + "'");
        //    pais.Text = referencia.Consulta1("Planilla p , Registro r , Departamento d, Sucursal s", "s.Pais", "p.Departamento = r.no_registro AND d.Serie_dept = r.depto_id AND S.Serie_Suc = R.sede_id AND p.Nombre_usuario", "'" + nom.Text + "'");


        }

        public string Getdepto(){
            return depto.Text;

        }
        public Label depa {
            get
            {
                return depto;
            }
            set {
                depto = value;
            }
        }
      
    }

}
