using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Collections;


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
        public System.Data.DataTable datos(String valor)
        {
            SqlCommand com = new SqlCommand();
            com.Connection = conexion;
            SqlCommand query = new SqlCommand("Listado", conexion);
            query.CommandType = CommandType.StoredProcedure;
            conectarServidor();
            query.Parameters.Add("@depto", SqlDbType.Int, 4);
            query.Parameters["@depto"].Value = valor;
         SqlDataAdapter   adaptador = new SqlDataAdapter(query);
         DataTable tabla = new DataTable();
         adaptador.Fill(tabla);
         return tabla;
        }
        [WebMethod]
        public string Consulta1(String tabla, String columna, String valor, String get) {
            String aux1 = "";
            SqlCommand com = new SqlCommand();
            com.Connection = conexion;
            com.CommandText = "SELECT " + columna + " FROM " + tabla + " WHERE " + valor + " = " + get;
            conectarServidor();
              SqlDataReader reader = com.ExecuteReader();
              while (reader.Read())
              {
                  if (reader.GetFieldType(0) == Type.GetType("System.Int32")) {
                      aux1 = reader.GetInt32(0).ToString();
                
                  }  else if (reader.GetFieldType(0) == Type.GetType("System.String")){
                            aux1 = reader.GetString(0);
                  }
                
              }
            return aux1;
        }
        [WebMethod]
        public int Login(String usuario , String contraseña, String Rol)
        {
            int carga = 0;
            try{
                 
            
            SqlCommand com = new SqlCommand();
            com.Connection = conexion;
           
            if (Rol == "Administrador" || Rol == "Empleado" || Rol == "Director") {
                com.CommandText = "SELECT p.Departamento FROM Planilla p WHERE p.Contraseña ='" + contraseña + "' AND p.Nombre_usuario='" + usuario + "' AND p.Cargo = '"+Rol + "'";
                
            }
            else if (Rol == "usuario") {
                com.CommandText = "SELECT c.Contraseña FROM Cliente c WHERE c.Contraseña='" + contraseña + "' AND c.Nombre_usuario='" + usuario + "' AND c.Cas_Int IS NOT NULL";
            }


            conectarServidor();
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {

                if (Rol == "Administrador")
                {
                    carga= 1;
                }
                else if (Rol == "Director")
                {
                    if (reader.GetInt32(0) == 1) {
                        carga= 2;

                    }
                    else if (reader.GetInt32(0) == 2)
                    {
                        carga= 3;
                    }
                    else if (reader.GetInt32(0) == 3)
                    {
                        carga= 4;
                    }
                }
                else if (Rol == "Empleado")
                {
                    if (reader.GetInt32(0) == 1)
                    {
                        carga= 5;
                    }
                    else if (reader.GetInt32(0) == 2)
                    {
                        carga= 6;
                    }
                    else if (reader.GetInt32(0) == 3)
                    {
                        carga= 7;
                    }
                }
                else if (Rol == "Cliente")
                {
                    carga =8;
                }
                else
                    carga= 0;

            }
            conexion.Close();
        }catch(Exception e){
    }
            return carga;
        }
       [WebMethod]
       public bool Update(String tabla, String columna, String valor, String restriccion1, String restriccion2)
       {
           bool cumplido = false;
           string res = "";
           try
           {
               SqlCommand cm = new SqlCommand();
               cm.Connection = conexion;
               cm.CommandText = "UPDATE " + tabla +" SET "+columna+" = "+valor+" WHERE "+ restriccion1+" = "+restriccion2 ;
               res = "UPDATE " + tabla + " SET " + columna + " = " + valor + " WHERE " + restriccion1 + " = " + restriccion2;
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



           }
           return cumplido;
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
        [WebMethod]
        public ArrayList Consulta(String tablas, String columnas, String llaves, String get) {
            ArrayList retorno = new ArrayList();
          //  string retorno = "";
            string aux1 = "";
            string aux2 = "";
            SqlCommand com = new SqlCommand();
            com.Connection = conexion;
            aux1 = "SELECT " + columnas;
            aux1 = aux1 + " FROM " + tablas;
            aux1 = aux1 + " WHERE " + llaves;
            aux1 = aux1 + " " + get;
            com.CommandText = aux1;
            conectarServidor();
            SqlDataReader reader = com.ExecuteReader();
            string[] aux3 = columnas.Split(',');
            
            while (reader.Read()) {
                if (reader.GetFieldType(0) == Type.GetType("System.Int32"))
                {
                    aux2 = reader.GetInt32(0).ToString();

                }
                else if (reader.GetFieldType(0) == Type.GetType("System.String"))
                {
                    aux2 = reader.GetString(0);
                }           
                for (int a = 1; a < aux3.Count() ; a++)
                {
                    if (reader.GetFieldType(a) == Type.GetType("System.Int32"))
                    {
                        aux2 = aux2 + " "+ reader.GetInt32(a).ToString();

                    }
                    else if (reader.GetFieldType(a) == Type.GetType("System.String"))
                    {
                        aux2 = aux2+" "+reader.GetString(a);
                    }   

                }
                retorno.Add(aux2);
            }

            return retorno;
        }
    }
}
