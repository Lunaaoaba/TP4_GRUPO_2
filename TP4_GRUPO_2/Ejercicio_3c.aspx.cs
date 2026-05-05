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
        
        private string consultaSQL = "SELECT * FROM Libros";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AccesoDatos.CargarGv(gvTodosLibros, consultaSQL);
            }
        }

        protected void LNBVolver_Click(object sender, EventArgs e)
        {
            Server.Transfer("Ejercicio 3a.aspx");
        }
    }
}