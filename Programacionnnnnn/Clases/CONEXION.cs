
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sirve para conectarse  a la BD
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Programacionnnnnn.Clases
{
    class CONEXION
    {
        private string setencial;

        private SqlConnection conn = new SqlConnection();
        private SqlCommand;
        
        public CONEXION()
        {

        }
        public CONEXION (string Setencial)
        {
            this.setencial = Setencial;
        }

        public string EJECUTAR()
        {
            conn.ConnectionString = Clases.globales.miconexion;
            if(conn.State != ConnectionState.Open)
            {
                conn.Close();
                conn.Open();
            }
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = Sentencial;
            cmd.ExecuteNonQuery();
            conn.Close();
            return "Operacion Exitosa";
        }
    }
}
