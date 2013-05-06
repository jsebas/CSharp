using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BaseDatos;


namespace EasyShopBP
{
   public class ClasesTipos
    {
        public void CrearCliente(string strCI, string strNombre, string strApellido, string strDireccion,
            string strTelefono)
        {
           
                ClasesTipos2 objClasesEnumeradas = new ClasesTipos2();//Objeto de la clase ConfiguracionNegocio

                objClasesEnumeradas.CreaCliente(strCI, strNombre, strApellido, strDireccion, strTelefono);

        }


        public void ActualizarCliente(string strCI, string strNombre, string strApellido, string strDireccion,
            string strTelefono)
        {

            ClasesTipos2 objClasesEnumeradas = new ClasesTipos2();//Objeto de la clase ConfiguracionNegocio

            objClasesEnumeradas.ActualizarCliente(strCI, strNombre, strApellido, strDireccion, strTelefono);

        }

        public void EliminarCliente(string strCI)
             {


                 ClasesTipos2 objClasesEnumeradas = new ClasesTipos2();//Objeto de la clase ConfiguracionNegocio
                 objClasesEnumeradas.EliminarCliente(strCI);
              
            }

            public DataTable ConsultarCliente()
            {

                ClasesTipos2 objClasesEnumeradas = new ClasesTipos2();
                return objClasesEnumeradas.ConsultarCliente();           
            }

            
            /// /////////////////////////Proveedor//////////////////////////
            
            public void CrearProveedor(string strID, string strNombre, string strTelefono, string strDireccion)
            {

                ClasesTipos2 objClasesEnumeradas = new ClasesTipos2();//Objeto de la clase ConfiguracionNegocio

                objClasesEnumeradas.CrearProveedor(strID, strNombre, strTelefono, strDireccion);

            }

            public void ActualizarProveedor(string strID, string strNombre, string strTelefono, string strDireccion)
            {

                ClasesTipos2 objClasesEnumeradas = new ClasesTipos2();//Objeto de la clase ConfiguracionNegocio

                objClasesEnumeradas.ActualizarProveedor(strID, strNombre, strTelefono, strDireccion);

            }

            public void EliminarProveedor(string strID)
            {


                ClasesTipos2 objClasesEnumeradas = new ClasesTipos2();//Objeto de la clase ConfiguracionNegocio
                objClasesEnumeradas.EliminarProveedor(strID);

            }

            public DataTable ConsultarProveedor()
            {

                ClasesTipos2 objClasesEnumeradas = new ClasesTipos2();
                return objClasesEnumeradas.ConsultarProveedor();
            }

            /// //////////////////////////////ESTABLECIMIENTO///////////////////////

            public void CrearEstablecimiento(string strID, string strNombre, string strTelefono, string strDireccion)
            {

                ClasesTipos2 objClasesEnumeradas = new ClasesTipos2();//Objeto de la clase ConfiguracionNegocio

                objClasesEnumeradas.CrearEstablecimiento(strID, strNombre, strTelefono, strDireccion);

            }

            public void ActualizarEstablecimiento(string strID, string strNombre, string strTelefono, string strDireccion)
            {

                ClasesTipos2 objClasesEnumeradas = new ClasesTipos2();//Objeto de la clase ConfiguracionNegocio

                objClasesEnumeradas.ActualizarEstablecimiento(strID, strNombre, strTelefono, strDireccion);

            }

            public void EliminarEstablecimiento(string strID)
            {


                ClasesTipos2 objClasesEnumeradas = new ClasesTipos2();//Objeto de la clase ConfiguracionNegocio
                objClasesEnumeradas.EliminarEstablecimiento(strID);

            }

            public DataTable ConsultarEstablecimiento()
            {

                ClasesTipos2 objClasesEnumeradas = new ClasesTipos2();
                return objClasesEnumeradas.ConsultarEstablecimiento();
            }
        
    }
 }

