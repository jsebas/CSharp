using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace BaseDatos
{
    public class ConexionBDD
    {
        public SqlConnection ConectSQL; //sqlConnection : la clase que administra la conexion

        public void Abrir()
        {
            ConectSQL = new SqlConnection("user id=wolfy;" +
                                       "server=wolfgang-pc\\sqlexpress;" + 
                                       "Trusted_Connection=false;" + 
                                       "database=EasyShop; " + 
                                       "connection timeout=30");
            ConectSQL.Open(); // ConectSQL es el objeto del SqlCOnnection
        }

        public void Cerrar()
        {
            ConectSQL.Close();
        }
    }
}
