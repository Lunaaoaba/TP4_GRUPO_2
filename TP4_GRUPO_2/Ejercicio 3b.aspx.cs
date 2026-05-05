using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.DynamicData;

namespace TP4_GRUPO_2
{
    public partial class Ejercicio_3b : System.Web.UI.Page
    {
        private const string conexionBBD = @"Data Source=localhost\sqlexpress;Initial Catalog=Libreria;Integrated Security=True";
        private string consultaSQL = "SELECT * FROM Libros";

        private void CargarGv()
        {
            SqlConnection conexiongv = new SqlConnection(conexionBBD);
            conexiongv.Open();

            SqlCommand comandogv = new SqlCommand(consultaSQL, conexiongv);
            SqlDataReader lecturagv = comandogv.ExecuteReader();

            gvLibros.DataSource = lecturagv;
            gvLibros.DataBind();

            conexiongv.Close(); 
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               string temaseleccionado = ((DropDownList)PreviousPage.FindControl("ddlTemas")).SelectedValue; 

               if(temaseleccionado != null)
               {
                  consultaSQL = "SELECT * FROM Libros WHERE IdTema = " + temaseleccionado;
               }
                   CargarGv();
            }
        }

        protected void LNBConsultar_Click(object sender, EventArgs e)
        {
            Server.Transfer("Ejercicio 3a.aspx");
        }
    }
}