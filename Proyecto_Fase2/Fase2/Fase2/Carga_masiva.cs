using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Collections;
using System.Windows.Forms;

namespace Fase2
{
    public class Carga_masiva
    {
        private ServiceReference1.WebService1SoapClient referencia = new ServiceReference1.WebService1SoapClient();
        public void bodega(String path, String suc)
        {
            StreamReader reader = new StreamReader(path);
            String linea;
            ArrayList lotes = new ArrayList();
            linea = reader.ReadLine();
            while (linea != null)
            {
                linea = reader.ReadLine();

                if (linea != null)
                {
                    lotes.Add(linea);
                }
            }
            reader.Close();
            foreach (string lote in lotes)
            {
                String[] datos = lote.Split(',');
                if (datos.Count() == 5) { 
                // tiene todos los datos
                    String aux1 = referencia.Consulta1("Lote l", "l.destino", "l.estado = 'En stock' AND l.id_lote ", datos[0]);
                    if (aux1 == suc)
                    {
                        // el paquete esta en stock y estamos en la sucursal correcta
                        String aux2 = datos[1].Replace(' ', '_');
                        String aux3 = referencia.Consulta1("Impuesto i", "i.Serie_imp", "i.Nombre", "'" + datos[1] + "'");
                        if (aux3 != "")
                        {
                           String aux4 = referencia.Consulta1("Cliente c","c.DPI","c.Cas_Int", datos[2]);
                            if(aux4 != ""){
                            // hasta aqui todo, bien ahora veamos si el paquete existe
                               String aux5 = referencia.Consulta1("Paquete p","p.ID_paquete"," p.Lote = "+datos[0]+" AND p.Categoria = "+aux3+" AND p.Cliente = "+aux4+" AND p.Peso_lb = "+datos[3]+" AND p.Precio ", datos[4]);
                                if(aux5 == ""){
                                MessageBox.Show("El paquete esta perdido");
                                    referencia.Ingresar("Paquete", " Cliente,Categoria,Peso_lb,Precio,Estado,Destino,Lote ", aux4 + "," + aux3 + "," + datos[3] + "," + datos[4] + ",'Perdido'," + suc+","+datos[0]);
                                } else { MessageBox.Show("El paquete esta registrado :)"); }

                            } else{   MessageBox.Show("el cliente no existe"); }
                        }
                        else { MessageBox.Show("Lo siento el impuesto no existe"); }

                    }
                    else { MessageBox.Show("El paquete no existe en la sucursal o no esta en Stock todavia"); }

                }

                

            }
        }
        public void Registros(String path) {
            StreamReader reader = new StreamReader(path);
            String linea;
            ArrayList paquetes = new ArrayList();
            linea = reader.ReadLine();
            while (linea != null)
            {
                linea = reader.ReadLine();

                if (linea != null)
                {
                    paquetes.Add(linea);
                }
            }
            reader.Close();
            foreach (string paquete in paquetes)
            {
                MessageBox.Show(paquete);
                String[] datos = paquete.Split(',');
                if (datos.Count() == 5)
                {
                    MessageBox.Show("tiene todos los valores");
                    //validamos que la categoria exista
                    String aux1 = datos[0].Replace(' ','_').ToLower();
                    String auxcate = referencia.Consulta1("Impuesto", "Nombre", "Nombre", "'"+aux1+"'");
                   
                    if (aux1 == auxcate.ToLower()) {
                    //    MessageBox.Show("el impuesto si existe");
                        String cateno = referencia.Consulta1("Impuesto", "Serie_imp", "Nombre", "'" + aux1 + "'");
                        //verificamos si el usuario existe
                        String auxcasi = referencia.Consulta1("Cliente", "DPI", "Cas_Int", datos[1]);
                        if (auxcasi != "") {
                      //      MessageBox.Show("el usuario existe");
                            //verificamos que el destino exista
                            String auxsucu = referencia.Consulta1("Sucursal", "Serie_Suc", "Serie_Suc", datos[4]);
                            if (auxsucu != "") {
                          //      MessageBox.Show("la sucursal existe");
                            //    MessageBox.Show("agregamos");

                                if (referencia.Ingresar("Paquete", "Cliente,Categoria,Peso_lb,Precio,Estado,Destino", auxcasi + "," + cateno + "," + datos[2] + "," + datos[3] + ",'Registrado'," + datos[4]))
                                {
                                    MessageBox.Show("paquete ingresado con exito");
                                }
                                else { MessageBox.Show("Ha ocurrido un error"); }
                            }

                        }
                    }
                }

            }

        }
        public void Impuesto(String path) {
            StreamReader reader = new StreamReader(path);
            String linea;
            ArrayList impuestos = new ArrayList();
            linea = reader.ReadLine();
            while (linea != null)
            {
                linea = reader.ReadLine();

                if (linea != null)
                {
                    impuestos.Add(linea);
                }
            }
            reader.Close();

            foreach (string impuesto in impuestos) {
             //   MessageBox.Show(impuesto);
                String[] datos = impuesto.Split(',');
                if (datos.Count() == 2) {
                    String aux1 = datos[0].Replace(' ', '_'); // reemplazamos
                    MessageBox.Show("si tiene los 2 valores");
                    String aux2 = datos[1].TrimEnd('%');
               //     MessageBox.Show("el nombre seria asi :" + aux1 + " el valor seria asi: " + aux2);
                    if (referencia.Ingresar("Impuesto", "Nombre,Porcentaje", "'" + aux1 + "'," + aux2)) {
                        MessageBox.Show("impuesto agregado con exito");
                    }

                }
            
            }

        }

        public void Empleado(String path, String registro) {
           
            StreamReader reader = new StreamReader(path);
            String linea;
            ArrayList empleados = new ArrayList();
            linea = reader.ReadLine();
            while (linea != null)
            {
                linea = reader.ReadLine();
                
                if (linea != null)
                {
                    empleados.Add(linea);
                }
            }
            reader.Close();
           

            foreach (string empleado in empleados) {
               MessageBox.Show(empleado);
                String[] datos = empleado.Split(',');
                if (datos.Count() == 5) {
                    // validacion que los 5 datos vengan completos
                    MessageBox.Show("si tiene todos sus datos");
                   
                        //validacion, solo empleados que el director pueda agregar o que la suc y el dep existan
                        if (registro == "Administrador")
                        {
                            // el administrador agrega cualquier empleado de cualquier departamento de cualquier sucursal
                            
                            string aux1 = "";
                            if (datos[4] == "Servicio al Cliente") { datos[4] = "Servicio_cliente"; }
                            
                          
                            aux1 = referencia.Consulta1("Registro r, Sucursal s,Departamento d", "r.no_registro", "d.Serie_dept = r.depto_id AND s.Serie_Suc = r.sede_id AND d.Nombre = '" + datos[4] + "' AND s.Direccion", "'" + datos[3] + "'");
                       //     MessageBox.Show("que demonios es aux1 == " + aux1 + " ; el cambio fue correcto? "+datos[4]);
                            if (aux1 != "") {
                                String aux3 = referencia.Consulta1("Empleado e", "MAX( e.ID_Empleado)", "e.ID_Empleado", "e.ID_Empleado");
                                int aux4 = Convert.ToInt32(aux3);
                                aux4 = aux4 + 1;
                 
                                referencia.Ingresar("Empleado", "ID_Empleado,Nombre,Apellido,DPI,Telefono,Domicilio", aux4.ToString() + ",'" + datos[1] + "','" + datos[0] + "'," + "010101" + "," + "010101" + ",'" + datos[3] + "'");
                                referencia.Ingresar("Planilla", "ID_empleado,Departamento,Cargo,Sueldo,Nombre_usuario,Contraseña", aux4.ToString() + "," + aux1 + ",'Empleado'," + datos[2] + ",'" + datos[1].ToLower() + "','" + "quetzalito" + "'");
                                MessageBox.Show("Empleado agregado con exito");
                            }
                           
                        }
                        else {
                            MessageBox.Show("es el director de " + registro);
                        // el director solamente agrega empleados de su depto y sucursal
                            if (registro == referencia.Consulta1("Registro r, Sucursal s,Departamento d", "r.no_registro", "d.Serie_dept = r.depto_id AND s.Serie_Suc = r.sede_id AND d.Nombre = '" + datos[8] + "' AND s.Direccion", "'" + datos[7]+"'")) {
                                String aux3 = referencia.Consulta1("Empleado e", "MAX( e.ID_Empleado)", "e.ID_Empleado", "e.ID_Empleado");
                                int aux4 = Convert.ToInt32(aux3);
                                aux4 = aux4 + 1;
                                referencia.Ingresar("Empleado", "ID_Empleado,Nombre,Apellido,DPI,Telefono,Domicilio", aux4.ToString() + ",'" + datos[1] + "','" + datos[0] + "'," + "010101" + "," + "010101" + ",'" + datos[3] + "'");
                                referencia.Ingresar("Planilla", "ID_empleado,Departamento,Cargo,Sueldo,Nombre_usuario,Contraseña", aux4.ToString() + "," + registro + ",'Empleado'," + datos[2] + ",'" + datos[1].ToLower() + "','" + "quetzalito" + "'");
                                MessageBox.Show("Empleado agregado con exito");

                            }
                        
                        }

                    }

                

            }
            
            

        }
    }
}