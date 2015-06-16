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
    public string Consulta_Clientes()
    {
        String carga = "";
        SqlCommand com = new SqlCommand();
        com.Connection = conexion;
        com.CommandText = "SELECT	c.Carnet FROM Cliente c";
        conectarServidor();
        SqlDataReader reader = com.ExecuteReader();
        while (reader.Read())
        {
            carga = carga + reader.GetInt32(0).ToString() + '/';

        }
        conexion.Close();
        return carga;
    }
    [WebMethod]
    public String Consulta_Libros(String libro) {
        String res = "";
      //  int res = 0;
        String lb = libro.ToString();
        try
        {
            SqlCommand com = new SqlCommand();
            com.Connection = conexion;
            com.CommandText = "SELECT  l.Nombre,l.Autor, l.Num_existencia,l.Disponible,l.Prestados,l.Reservados FROM Libro l WHERE l.Cod_Libro =" + lb;
            conectarServidor();
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
             
                   res = reader.GetString(0)+ '/';
                res = res + reader.GetString(1)+ '/';
                res = res + reader.GetInt32(2)+ '/';
                res = res + reader.GetInt32(3)+ '/';
                res = res + reader.GetInt32(4)+ '/';
                res = res + reader.GetInt32(5)+ '/';

            }

        }
        catch (Exception e) { 
        }
        conexion.Close();
        return res;

    }
    [WebMethod]
    public String Cargar_libros() { 
    String carga = "";
    SqlCommand com = new SqlCommand();
    com.Connection = conexion;
        com.CommandText = "SELECT l.Cod_Libro FROM Libro l";
        conectarServidor();
        SqlDataReader reader = com.ExecuteReader();
        while (reader.Read()) {
            carga = carga + reader.GetInt32(0).ToString()+ '/' ;

        }
        conexion.Close();
    return carga;
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