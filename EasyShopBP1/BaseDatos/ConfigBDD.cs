using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace BaseDatos
{
    public class ConfigBDD
    {
        public void CrearCliente(string strCI, string strNombre, string strApellido, string strDireccion,
            string strTelefono)
        {
           
           
            ConexionBDD objConexion = new ConexionBDD();
            objConexion.Abrir(); // objeto de la clase coneccion

            SqlCommand cmdComando = new SqlCommand("Crear_Cliente", objConexion.ConectSQL);
            cmdComando.CommandType = CommandType.StoredProcedure;

            SqlParameter sqlParametro = new SqlParameter();


            sqlParametro = new SqlParameter("@i_CI", SqlDbType.Char, 10);
            sqlParametro.Value = strCI;
            cmdComando.Parameters.Add(sqlParametro);

            sqlParametro = new SqlParameter("@i_nombre_Cl", SqlDbType.VarChar, 50);
            sqlParametro.Value = strNombre;
            cmdComando.Parameters.Add(sqlParametro);

            sqlParametro = new SqlParameter("@i_apellido_Cl", SqlDbType.VarChar, 50);
            sqlParametro.Value = strApellido;
            cmdComando.Parameters.Add(sqlParametro);

            sqlParametro = new SqlParameter("@i_direccion_Cl", SqlDbType.VarChar, 50);
            sqlParametro.Value = strDireccion;
            cmdComando.Parameters.Add(sqlParametro);

            sqlParametro = new SqlParameter("@i_telefono_Cl", SqlDbType.VarChar, 50);
            sqlParametro.Value = strTelefono;
            cmdComando.Parameters.Add(sqlParametro);


            cmdComando.ExecuteNonQuery();

            objConexion.Cerrar();//Cierra Conexion
                
        }
        

        public void ActualizarCliente(string strCI, string strNombre, string strApellido, string strDireccion,
            string strTelefono)//Actualiza Cliente
        {

            ConexionBDD objConexion = new ConexionBDD();
            objConexion.Abrir(); // objeto de la clase coneccion

            SqlCommand cmdComando = new SqlCommand("Crear_Actualiza_Cliente", objConexion.ConectSQL);
            cmdComando.CommandType = CommandType.StoredProcedure;

            SqlParameter sqlParametro = new SqlParameter();


            sqlParametro = new SqlParameter("@i_CI", SqlDbType.VarChar, 50);
            sqlParametro.Value = strCI;
            cmdComando.Parameters.Add(sqlParametro);

            sqlParametro = new SqlParameter("@i_nombre_Cl", SqlDbType.VarChar, 50);
            sqlParametro.Value = strNombre;
            cmdComando.Parameters.Add(sqlParametro);

            sqlParametro = new SqlParameter("@i_apellido_Cl", SqlDbType.VarChar, 50);
            sqlParametro.Value = strApellido;
            cmdComando.Parameters.Add(sqlParametro);

            sqlParametro = new SqlParameter("@i_direccion_Cl", SqlDbType.VarChar, 50);
            sqlParametro.Value = strDireccion;
            cmdComando.Parameters.Add(sqlParametro);

            sqlParametro = new SqlParameter("@i_telefono_Cl", SqlDbType.VarChar, 50);
            sqlParametro.Value = strTelefono;
            cmdComando.Parameters.Add(sqlParametro);

            cmdComando.ExecuteNonQuery();

            objConexion.Cerrar();//Cierra Conexion

        }

        public void RemoverCliente(string strCI)//Elimina Cliente
        {

            ConexionBDD objConexion = new ConexionBDD();
            objConexion.Abrir(); // objeto de la clase coneccion

            SqlCommand cmdComando = new SqlCommand("Eliminar_Cliente", objConexion.ConectSQL);
            cmdComando.CommandType = CommandType.StoredProcedure;

            SqlParameter sqlParametro = new SqlParameter();


            sqlParametro = new SqlParameter("@i_CI", SqlDbType.VarChar, 50);
            sqlParametro.Value = strCI;
            cmdComando.Parameters.Add(sqlParametro);


            cmdComando.ExecuteNonQuery();

            objConexion.Cerrar();//Cierra Conexion

        }

         public DataTable ConsultarCliente()//Recuepra Marca
        {
            
                ConexionBDD objConexion = new ConexionBDD();
                objConexion.Abrir(); // objeto de la clase coneccion

                SqlDataAdapter objDataAdapter = new SqlDataAdapter();
                SqlCommand cmdComando = new SqlCommand("Consulta_Cliente", objConexion.ConectSQL);
                cmdComando.CommandType = CommandType.StoredProcedure;

                objDataAdapter.SelectCommand = cmdComando;

                DataTable dtMarca = new DataTable();//objeto de Datatable

                objDataAdapter.Fill(dtMarca);

                objConexion.Cerrar();//Cierra Conexion

                return dtMarca;

       }

        /// //////////////////////////////////PROVEEDOR//////////////////////////////////////

         public void CrearProveedor(string strID, string strNombre, string strDireccion,
             string strTelefono)
         {


             ConexionBDD objConexion = new ConexionBDD();
             objConexion.Abrir(); // objeto de la clase coneccion

             SqlCommand cmdComando = new SqlCommand("Crear_Proveedor", objConexion.ConectSQL);
             cmdComando.CommandType = CommandType.StoredProcedure;

             SqlParameter sqlParametro = new SqlParameter();


             sqlParametro = new SqlParameter("@i_IDProv", SqlDbType.Char, 10);
             sqlParametro.Value = strID;
             cmdComando.Parameters.Add(sqlParametro);

             sqlParametro = new SqlParameter("@i_NombreProv", SqlDbType.VarChar, 50);
             sqlParametro.Value = strNombre;
             cmdComando.Parameters.Add(sqlParametro);

             sqlParametro = new SqlParameter("@i_DireccionProv", SqlDbType.VarChar, 50);
             sqlParametro.Value = strDireccion;
             cmdComando.Parameters.Add(sqlParametro);

             sqlParametro = new SqlParameter("@i_TelefonoProv", SqlDbType.VarChar, 50);
             sqlParametro.Value = strTelefono;
             cmdComando.Parameters.Add(sqlParametro);


             cmdComando.ExecuteNonQuery();

             objConexion.Cerrar();//Cierra Conexion

         }

         public void ActualizarProveedor(string strID, string strNombre, string strDireccion,
             string strTelefono)//Actualiza Cliente
         {

             ConexionBDD objConexion = new ConexionBDD();
             objConexion.Abrir(); // objeto de la clase coneccion

             SqlCommand cmdComando = new SqlCommand("Crear_Actualiza_Proveedor", objConexion.ConectSQL);
             cmdComando.CommandType = CommandType.StoredProcedure;

             SqlParameter sqlParametro = new SqlParameter();


             sqlParametro = new SqlParameter("@i_IDProv", SqlDbType.Char, 10);
             sqlParametro.Value = strID;
             cmdComando.Parameters.Add(sqlParametro);

             sqlParametro = new SqlParameter("@i_NombreProv", SqlDbType.VarChar, 50);
             sqlParametro.Value = strNombre;
             cmdComando.Parameters.Add(sqlParametro);

             sqlParametro = new SqlParameter("@i_DireccionProv", SqlDbType.VarChar, 50);
             sqlParametro.Value = strDireccion;
             cmdComando.Parameters.Add(sqlParametro);

             sqlParametro = new SqlParameter("@i_TelefonoProv", SqlDbType.VarChar, 50);
             sqlParametro.Value = strTelefono;
             cmdComando.Parameters.Add(sqlParametro);

             cmdComando.ExecuteNonQuery();

             objConexion.Cerrar();//Cierra Conexion

         }

         public void RemoverProveedor(string strID)//Elimina Cliente
         {

             ConexionBDD objConexion = new ConexionBDD();
             objConexion.Abrir(); // objeto de la clase coneccion

             SqlCommand cmdComando = new SqlCommand("Eliminar_Proveedor", objConexion.ConectSQL);
             cmdComando.CommandType = CommandType.StoredProcedure;

             SqlParameter sqlParametro = new SqlParameter();


             sqlParametro = new SqlParameter("@i_IDProv", SqlDbType.Char, 10);
             sqlParametro.Value = strID;
             cmdComando.Parameters.Add(sqlParametro);


             cmdComando.ExecuteNonQuery();

             objConexion.Cerrar();//Cierra Conexion

         }

         public DataTable ConsultarProveedor()//Recuepra Marca
         {

             ConexionBDD objConexion = new ConexionBDD();
             objConexion.Abrir(); // objeto de la clase coneccion

             SqlDataAdapter objDataAdapter = new SqlDataAdapter();
             SqlCommand cmdComando = new SqlCommand("Consulta_Proveedor", objConexion.ConectSQL);
             cmdComando.CommandType = CommandType.StoredProcedure;

             objDataAdapter.SelectCommand = cmdComando;

             DataTable dtMarca = new DataTable();//objeto de Datatable

             objDataAdapter.Fill(dtMarca);

             objConexion.Cerrar();//Cierra Conexion

             return dtMarca;

         }

        /// /////////////////////////////ESTABLECIMIENTO///////////////////////////////

         public void CrearEstablecimiento(string strID, string strNombre, string strDireccion,
              string strTelefono)
         {


             ConexionBDD objConexion = new ConexionBDD();
             objConexion.Abrir(); // objeto de la clase coneccion

             SqlCommand cmdComando = new SqlCommand("Crear_Establecimiento", objConexion.ConectSQL);
             cmdComando.CommandType = CommandType.StoredProcedure;

             SqlParameter sqlParametro = new SqlParameter();


             sqlParametro = new SqlParameter("@i_IDEst", SqlDbType.Char, 10);
             sqlParametro.Value = strID;
             cmdComando.Parameters.Add(sqlParametro);

             sqlParametro = new SqlParameter("@i_NombreEst", SqlDbType.VarChar, 50);
             sqlParametro.Value = strNombre;
             cmdComando.Parameters.Add(sqlParametro);

             sqlParametro = new SqlParameter("@i_DireccionEst", SqlDbType.VarChar, 50);
             sqlParametro.Value = strDireccion;
             cmdComando.Parameters.Add(sqlParametro);

             sqlParametro = new SqlParameter("@i_TelefonoEst", SqlDbType.VarChar, 50);
             sqlParametro.Value = strTelefono;
             cmdComando.Parameters.Add(sqlParametro);


             cmdComando.ExecuteNonQuery();

             objConexion.Cerrar();//Cierra Conexion

         }

         public void ActualizarEstablecimiento(string strID, string strNombre, string strDireccion,
              string strTelefono)//Actualiza Cliente
         {

             ConexionBDD objConexion = new ConexionBDD();
             objConexion.Abrir(); // objeto de la clase coneccion

             SqlCommand cmdComando = new SqlCommand("Crear_Actualiza_Establecimiento", objConexion.ConectSQL);
             cmdComando.CommandType = CommandType.StoredProcedure;

             SqlParameter sqlParametro = new SqlParameter();


             sqlParametro = new SqlParameter("@i_IDEst", SqlDbType.Char, 10);
             sqlParametro.Value = strID;
             cmdComando.Parameters.Add(sqlParametro);

             sqlParametro = new SqlParameter("@i_NombreEst", SqlDbType.VarChar, 50);
             sqlParametro.Value = strNombre;
             cmdComando.Parameters.Add(sqlParametro);

             sqlParametro = new SqlParameter("@i_DireccionEst", SqlDbType.VarChar, 50);
             sqlParametro.Value = strDireccion;
             cmdComando.Parameters.Add(sqlParametro);

             sqlParametro = new SqlParameter("@i_TelefonoEst", SqlDbType.VarChar, 50);
             sqlParametro.Value = strTelefono;
             cmdComando.Parameters.Add(sqlParametro);

             cmdComando.ExecuteNonQuery();

             objConexion.Cerrar();//Cierra Conexion

         }

         public void RemoverEstablecimiento(string strID)//Elimina Cliente
         {

             ConexionBDD objConexion = new ConexionBDD();
             objConexion.Abrir(); // objeto de la clase coneccion

             SqlCommand cmdComando = new SqlCommand("Eliminar_Establecimiento", objConexion.ConectSQL);
             cmdComando.CommandType = CommandType.StoredProcedure;

             SqlParameter sqlParametro = new SqlParameter();


             sqlParametro = new SqlParameter("@i_IDEst", SqlDbType.Char, 10);
             sqlParametro.Value = strID;
             cmdComando.Parameters.Add(sqlParametro);


             cmdComando.ExecuteNonQuery();

             objConexion.Cerrar();//Cierra Conexion

         }

         public DataTable ConsultarEstablecimiento()//Recuepra Marca
         {

             ConexionBDD objConexion = new ConexionBDD();
             objConexion.Abrir(); // objeto de la clase coneccion

             SqlDataAdapter objDataAdapter = new SqlDataAdapter();
             SqlCommand cmdComando = new SqlCommand("Consulta_Establecimiento", objConexion.ConectSQL);
             cmdComando.CommandType = CommandType.StoredProcedure;

             objDataAdapter.SelectCommand = cmdComando;

             DataTable dtMarca = new DataTable();//objeto de Datatable

             objDataAdapter.Fill(dtMarca);

             objConexion.Cerrar();//Cierra Conexion

             return dtMarca;

         }
    }
}
