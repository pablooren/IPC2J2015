using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]

public class Service : System.Web.Services.WebService
{
    public Service () {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hola a todos";
    }

   SqlConnection conexion = new SqlConnection();
    string mostrarError;

    public string MostrarEstado;

    public string MostrarError
    {
        get { return mostrarError; }
        set { mostrarError = value; }
    }
    [WebMethod]
    public bool conectarServidor()
    {
        bool respuesta = false;
        string cadenaConexion = @"Data Source=PABLOOREN\SQLEXPRESS;Initial Catalog=Practica_IPC2J;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
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
    public bool Registrar(string Tabla, string Campos, string Valores)
    {
        bool respuesta = false;
        try
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = conexion;
            cm.CommandText = "INSERT INTO " + Tabla + "(" + Campos + ") VALUES (" + Valores + ");";
            conectarServidor();

            if (conectarServidor())
            {
                if (cm.ExecuteNonQuery() == 1)
                    respuesta = true;
                else
                    respuesta = false;

            }
            else
            {
                respuesta = false;
            }

        }
        catch (Exception e)
        {
            respuesta = false;
            //MostrarError = "Erro: " + e.Message.ToString();
        }
        finally
        {
            conexion.Close();
        }

        return respuesta;
    }

}