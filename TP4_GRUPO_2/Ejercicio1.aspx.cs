using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace TP4_GRUPO_2
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        private const string conexion = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Viajes;Integrated Security=True;Encrypt=False";
        private string consulta = "SELECT * FROM Localidades";

        protected void Page_Load(object sender, EventArgs e)
        {


        }
    }
}