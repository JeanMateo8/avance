using CDATOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNEGOCIOS
{
    public class Persona
    {
        DBAccess acceso = new DBAccess();

        public DataTable listarActivos()
        {
            return acceso.getDataFrom("spu_listar_personas", 1);
        }

        public DataTable registrar(string apellidos, string nombres, string dni, string telefono)
        {
            DataTable data = new DataTable();

            acceso.conectar();

            SqlCommand cmd = new SqlCommand("spu_registrar_personas", acceso.getconxion());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@apellido", apellidos);
            cmd.Parameters.AddWithValue("@nombre", nombres);
            cmd.Parameters.AddWithValue("@dni",dni);
            cmd.Parameters.AddWithValue("@telefono",telefono);

            data.Load(cmd.ExecuteReader());

            acceso.desconectar();

            return data;
        }

        public DataTable Modificar(int id, string apellidos, string nombres, string dni, string telefono)
        {
            DataTable dt = new DataTable();
            acceso.conectar();
            SqlCommand sqlCommand = new SqlCommand("spu_modificar_personas", acceso.getconxion());
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@idpersona", id);
            sqlCommand.Parameters.AddWithValue("@apellidos", apellidos);
            sqlCommand.Parameters.AddWithValue("@nombres", nombres);
            sqlCommand.Parameters.AddWithValue("@dni", dni);
            sqlCommand.Parameters.AddWithValue("@telefono", telefono);

            dt.Load(sqlCommand.ExecuteReader());

            acceso.desconectar();

            return dt;
        }
    }
}
