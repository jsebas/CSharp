using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BaseDatos;
using System.Data;
using System.Data.SqlClient;

namespace EasyShopBP
{
    public class ClasesTipos2
    {
        public void CreaCliente(string strCI, string strNombre, string strApellido, string strDireccion,
            string strTelefono)
        {

            ConfigBDD objClasesEnumeradas2 = new ConfigBDD();//Objeto clase ConfiguracionBdd
            objClasesEnumeradas2.CrearCliente(strCI, strNombre, strApellido, strDireccion, strTelefono);//Crea Cliente
         
        }

        public DataTable ConsultarCliente()
        {

            ConfigBDD objClasesEnumeradas2 = new ConfigBDD();//Objeto clase ConfiguracionBdd
            return objClasesEnumeradas2.ConsultarCliente();//Recupera Cliente
        }

        public void ActualizarCliente(string strCI, string strNombre, string strApellido, string strDireccion,
            string strTelefono)
        {
           
                ConfigBDD objClasesEnumeradas2 = new ConfigBDD();//Objeto clase ConfiguracionBdd
                objClasesEnumeradas2.ActualizarCliente(strCI, strNombre, strApellido, strDireccion, strTelefono);//Actualiza datos del Cliente
           
        }

        public void EliminarCliente(string strCI)
        {
            
                ConfigBDD objClasesEnumeradas2 = new ConfigBDD();//Objeto clase ConfiguracionBdd
                objClasesEnumeradas2.RemoverCliente(strCI);//elimina Cliente
            
        }

        /// ///////////////////////////////////////PROVEEDOR///////////////////////////////////////////////

        public void CrearProveedor(string strID, string strNombre, string strTelefono, string strDireccion)
        {

            ConfigBDD objClasesEnumeradas2 = new ConfigBDD();//Objeto clase ConfiguracionBdd
            objClasesEnumeradas2.CrearProveedor(strID, strNombre, strTelefono, strDireccion);//Crea Cliente

        }

        public DataTable ConsultarProveedor()
        {

            ConfigBDD objClasesEnumeradas2 = new ConfigBDD();//Objeto clase ConfiguracionBdd
            return objClasesEnumeradas2.ConsultarProveedor();//Recupera Cliente
        }

        public void ActualizarProveedor(string strID, string strNombre, string strTelefono, string strDireccion)
        {

            ConfigBDD objClasesEnumeradas2 = new ConfigBDD();//Objeto clase ConfiguracionBdd
            objClasesEnumeradas2.ActualizarProveedor(strID, strNombre, strTelefono, strDireccion);//Actualiza datos del Cliente

        }

        public void EliminarProveedor(string strID)
        {

            ConfigBDD objClasesEnumeradas2 = new ConfigBDD();//Objeto clase ConfiguracionBdd
            objClasesEnumeradas2.RemoverProveedor(strID);//elimina Cliente

        }

        /// /////////////////////////////ESTABLECIMIENTO////////////////////////////////////////////////////////

        public void CrearEstablecimiento(string strID, string strNombre, string strTelefono, string strDireccion)
        {

            ConfigBDD objClasesEnumeradas2 = new ConfigBDD();//Objeto clase ConfiguracionBdd
            objClasesEnumeradas2.CrearEstablecimiento(strID, strNombre, strTelefono, strDireccion);//Crea Cliente

        }

        public DataTable ConsultarEstablecimiento()
        {

            ConfigBDD objClasesEnumeradas2 = new ConfigBDD();//Objeto clase ConfiguracionBdd
            return objClasesEnumeradas2.ConsultarEstablecimiento();//Recupera Cliente
        }

        public void ActualizarEstablecimiento(string strID, string strNombre, string strTelefono, string strDireccion)
        {

            ConfigBDD objClasesEnumeradas2 = new ConfigBDD();//Objeto clase ConfiguracionBdd
            objClasesEnumeradas2.ActualizarEstablecimiento(strID, strNombre, strTelefono, strDireccion);//Actualiza datos del Cliente

        }

        public void EliminarEstablecimiento(string strID)
        {

            ConfigBDD objClasesEnumeradas2 = new ConfigBDD();//Objeto clase ConfiguracionBdd
            objClasesEnumeradas2.RemoverEstablecimiento(strID);//elimina Cliente

        }
    }
}
