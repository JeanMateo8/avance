using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Agregamos biblioteca
using System.Data;
using System.Data.SqlClient;

namespace CDATOS
{
    public class DBAccess
    {
        SqlConnection conexion = new SqlConnection("data source=. ;database=sistema_licoreria;user id=sa;password=123456;integrated security=false");


        public SqlConnection getconxion()
        {
            return conexion;
        }

        public void conectar()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
        }

        public void desconectar()
        {
            if(conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }

        public DataTable getDataFrom(string spu, int estado)
        {
            DataTable dt = new DataTable();
            conectar();

            SqlCommand sqlCommand = new SqlCommand(spu, getconxion());
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@estado", estado);
            dt.Load(sqlCommand.ExecuteReader());

            desconectar();
            return dt;
        }
    }

    


}
