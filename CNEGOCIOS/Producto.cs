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
    public class Producto
    {
        DBAccess acceso = new DBAccess();

        public DataTable listarActivos()
        {
            return acceso.getDataFrom("spu_listar_producto", 1);
        }

        public DataTable registrar(string idmarca, string idcategoria, string nombreprod, string descripcion, string precio, string stock,string caducidad)
        {
            DataTable data = new DataTable();

            acceso.conectar();

            SqlCommand cmd = new SqlCommand("spu_registrar_producto", acceso.getconxion());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idmarca", idmarca );
            cmd.Parameters.AddWithValue("@idcategoria", idcategoria);
            cmd.Parameters.AddWithValue("@nombreproducto", nombreprod);
            cmd.Parameters.AddWithValue("@descripcion", descripcion);
            cmd.Parameters.AddWithValue("@precio",precio );
            cmd.Parameters.AddWithValue("@stock",stock );
            cmd.Parameters.AddWithValue("@cantidad", caducidad);
            

            data.Load(cmd.ExecuteReader());

            acceso.desconectar();

            return data;
        }

        public DataTable Modificar(string idmarca, string idcategoria, string nombreprod, string descripcion, string precio, string stock, string caducidad)
        {
            DataTable dt = new DataTable();
            acceso.conectar();
            SqlCommand cmd = new SqlCommand("spu_modificar_personas", acceso.getconxion());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idmarca", idmarca);
            cmd.Parameters.AddWithValue("@idcategoria", idcategoria);
            cmd.Parameters.AddWithValue("@nombreproducto", nombreprod);
            cmd.Parameters.AddWithValue("@descripcion", descripcion);
            cmd.Parameters.AddWithValue("@precio", precio);
            cmd.Parameters.AddWithValue("@stock", stock);
            cmd.Parameters.AddWithValue("@cantidad", caducidad);
            dt.Load(cmd.ExecuteReader());

            acceso.desconectar();

            return dt;
        }
    }
}
