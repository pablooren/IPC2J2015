using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Fase2
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        SqlConnection conexion = new SqlConnection();
        string mostrarError;
        public string MostrarEstado;
        public string MostrarError;
       [WebMethod]
        public bool Login(String usuario , String contraseña, String Rol)
        {
            bool carga = false;
            SqlCommand com = new SqlCommand();
            com.Connection = conexion;
            if (Rol == "Administrador" || Rol == "empleado") {
                com.CommandText = "SELECT p.Contraseña FROM Planilla p WHERE p.Contraseña='" + contraseña + "'AND p.Nombre_usuario='" + usuario + "'";

            }
            else if (Rol == "usuario") {
                com.CommandText = "SELECT c.Contraseña FROM Cliente c WHERE c.Contraseña='"+contraseña+"' AND c.Nombre_usuario='"+usuario+"'";
            }


            conectarServidor();
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetString(0).Equals(""))
                {
                    carga = false;
                }
                else {
                    carga = true;
                }

            }
            conexion.Close();
            return carga;
        }
       [WebMethod]
       public bool Ingresar(String Tabla, String columnas, String valores) {
           bool cumplido = false;
            try
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = conexion;
            cm.CommandText = "INSERT INTO " + Tabla + "(" + columnas + ") VALUES (" + valores + ");";
            conectarServidor();

            if (conectarServidor())
            {
                if (cm.ExecuteNonQuery() == 1)
                    cumplido = true;
                else
                    cumplido = false;

            }
            else
            {
                cumplido = false;
            }

        }
        catch (Exception e)
        {
            cumplido = false;
            //MostrarError = "Erro: " + e.Message.ToString();
        }
       
            conexion.Close();
       


           return cumplido;
       }
        [WebMethod]
        public bool conectarServidor()
        {
            bool respuesta = false;
            string cadenaConexion = @"Data Source=PABLOOREN\SQLEXPRESS;Initial Catalog=Quetzal_Express;Integrated Security=True";
            try
            {
                conexion.Close();
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                respuesta = true;
                MostrarEstado = "Conexion exitosa";
            }

            catch (Exception e)
            {
                respuesta = false;
                MostrarError = "No se ha podido conectar " + e.Message.ToString();
            }


            return respuesta;
        }


        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
    }
}
