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
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        private const string conexionNeptuno = @"Data Source=DESKTOP-Q8FUKTC\\SQLEXPRESS;Initial Catalog=Libreria;Integrated Security=True;Encrypt=False";
        private string consultaBdd = "SELECT * FROM Productos";

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}