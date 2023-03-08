using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CDATOS;

namespace CNEGOCIOS
{
    public class Empleado
    {
        DBAccess acceso = new DBAccess();
            
        public DataTable iniciarSesion(String nombreUsuario)
        {
            DataTable dataTable = new DataTable();

            acceso.conectar();
            SqlCommand sqlCommand = new SqlCommand("spu_empleados_login", acceso.getconxion());
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@nombreusuario", nombreUsuario);

            dataTable.Load(sqlCommand.ExecuteReader());

            acceso.desconectar();

            return dataTable;
        }

        public DataTable listarActivos()
        {
            return acceso.getDataFrom("spu_listar_empleado", 1);
        }

        public DataTable registrar(string id, string usuario, string clave)
        {
            DataTable dt = new DataTable();
            acceso.conectar();
            SqlCommand sqlCommand = new SqlCommand("spu_registrar_empleado", acceso.getconxion());
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@idpersona", id);
            sqlCommand.Parameters.AddWithValue("@nombreusuario", usuario);
            sqlCommand.Parameters.AddWithValue("@claveacceso", clave);


            dt.Load(sqlCommand.ExecuteReader());

            acceso.desconectar();

            return dt;
        }

        public DataTable modificar(int id, string clave)
        {
            DataTable dt = new DataTable();
            acceso.conectar();
            SqlCommand sqlCommand = new SqlCommand("spu_modificar_Empleado", acceso.getconxion());
            sqlCommand.CommandType = CommandType.StoredProcedure;


            sqlCommand.Parameters.AddWithValue("@idempleado", id);
            sqlCommand.Parameters.AddWithValue("@claveacceso", clave);


            dt.Load(sqlCommand.ExecuteReader());

            acceso.desconectar();

            return dt;
        }


    }
}
