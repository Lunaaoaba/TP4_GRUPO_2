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
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        private const string conexion = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Viajes;Integrated Security=True;Encrypt=False";
        private string consultaprovincias = "SELECT * FROM Provincias";
        private string consultalocalidades = "SELECT * FROM Localidades";

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conexionbasededatos = new SqlConnection(conexion); 
            conexionbasededatos.Open();

            SqlCommand comandobasededatos = new SqlCommand(consultaprovincias, conexionbasededatos);
            SqlDataReader lectorbasededatos = comandobasededatos.ExecuteReader(); 

            ddlProvincia.DataSource = lectorbasededatos;
            ddlProvincia.DataTextField = "NombreProvincia";
            ddlProvincia.DataValueField = "IdProvincia";
            ddlProvincia.DataBind();

            conexionbasededatos.Close();
        }
    }
}