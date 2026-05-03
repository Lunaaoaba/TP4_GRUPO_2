using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP4_GRUPO_2
{
    public partial class Ejercicio_3a : System.Web.UI.Page
    {
        private const string conexionBBD = @"Data Source=localhost\sqlexpress;Initial Catalog=Libreria;Integrated Security=True"; 
        private string consultaSQL = "SELECT * FROM Libros";
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}