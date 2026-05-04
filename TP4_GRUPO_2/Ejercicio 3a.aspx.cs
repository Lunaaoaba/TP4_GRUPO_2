using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace TP4_GRUPO_2
{
    public partial class Ejercicio_3a : System.Web.UI.Page
    {
        private const string conexionBBD = @"Data Source=localhost\sqlexpress;Initial Catalog=Libreria;Integrated Security=True"; 
        private string consultaSQL = "SELECT * FROM Temas";

        private void Cargarddl()
        {
            SqlConnection sqlConnectionTemas = new SqlConnection(conexionBBD);
            sqlConnectionTemas.Open();

            SqlCommand sqlCommandTemas = new SqlCommand(consultaSQL,sqlConnectionTemas);
            SqlDataReader sqlDataReaderTemas = sqlCommandTemas.ExecuteReader();

            ddlTemas.DataSource = sqlDataReaderTemas;
            ddlTemas.DataTextField = "Tema";
            ddlTemas.DataValueField = "IdTema";
            ddlTemas.DataBind();

            sqlConnectionTemas.Close();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Cargarddl();
            }
        }

        protected void LbtnLibros_Click(object sender, EventArgs e)
        {
            Server.Transfer("Ejercicio 3b.aspx");
        }

        protected void lbtnTodosLibros_Click(object sender, EventArgs e)
        {
            Server.Transfer("Ejercicio_3c.aspx");
        }
    }
}