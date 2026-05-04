using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.DynamicData;

namespace TP4_GRUPO_2
{
    public partial class Ejercicio_3c : System.Web.UI.Page
    {
        private const string conexionBBD = @"Data Source=localhost\sqlexpress;Initial Catalog=Libreria;Integrated Security=True";
        private string consultaSQL = "SELECT * FROM Libros";

        private void CargarGv()
        {
            SqlConnection conexiongv = new SqlConnection(conexionBBD);
            conexiongv.Open();

            SqlCommand comandogv = new SqlCommand(consultaSQL, conexiongv);
            SqlDataReader lecturagv = comandogv.ExecuteReader();

            gvTodosLibros.DataSource = lecturagv;
            gvTodosLibros.DataBind();

            conexiongv.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarGv();
            }
        }

        protected void LNBVolver_Click(object sender, EventArgs e)
        {
            Server.Transfer("Ejercicio 3a.aspx");
        }
    }
}