using System;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace TP4_GRUPO_2
{
    public class AccesoDatos
    {
        private const string conexionBBD = @"Data Source=localhost\sqlexpress;Initial Catalog=Libreria;Integrated Security=True";

        public static void CargarGv(GridView gv, string consultaSQL)
        {
            SqlConnection conexion = new SqlConnection(conexionBBD);
            conexion.Open();

            SqlCommand comando = new SqlCommand(consultaSQL, conexion);
            SqlDataReader lector = comando.ExecuteReader();

            gv.DataSource = lector;
            gv.DataBind();

            conexion.Close();
        }
    }
}