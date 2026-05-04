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
        private string consultaSQL = "SELECT * FROM Temas";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (PreviousPage != null)
                {
                    string temaseleccionado = ((DropDownList)PreviousPage.FindControl("ddlTemas")).SelectedValue;
                }
             }
        }
    }
}