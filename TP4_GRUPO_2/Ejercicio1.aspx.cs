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

        private void cargarProvinciaInicio()
        {
            SqlConnection conexionbasededatos = new SqlConnection(conexion);
            conexionbasededatos.Open();

            SqlCommand comandobasededatos = new SqlCommand(consultaprovincias, conexionbasededatos);
            SqlDataReader lectorbasededatos = comandobasededatos.ExecuteReader();

            while (lectorbasededatos.Read())
            {
                ddlProvincia.Items.Add(new ListItem(lectorbasededatos["NombreProvincia"].ToString(), lectorbasededatos["IdProvincia"].ToString()));
            }

            conexionbasededatos.Close();
        }
        private void cargarLocalidadInicio()
        {
            SqlConnection conexionLocalidad = new SqlConnection(conexion);
            conexionLocalidad.Open();

            SqlCommand comandoLocalidad = new SqlCommand(consultalocalidades, conexionLocalidad);
            SqlDataReader lectorLocalidad = comandoLocalidad.ExecuteReader();

            while (lectorLocalidad.Read())
            {
                ddlLocalidad.Items.Add(new ListItem(lectorLocalidad["NombreLocalidad"].ToString(), lectorLocalidad["IdLocalidad"].ToString()));
            }

            conexionLocalidad.Close();
        }

        private void cargarProvinciaFinal()
        {
            SqlConnection conexionProvDestino = new SqlConnection(conexion);
            conexionProvDestino.Open();

            SqlCommand comandoProvDestino = new SqlCommand(consultaprovincias, conexionProvDestino);
            SqlDataReader lectorProvDestino = comandoProvDestino.ExecuteReader();

            ddlProvinciaDestino.DataSource = lectorProvDestino;
            ddlProvinciaDestino.DataTextField = "NombreProvincia";
            ddlProvinciaDestino.DataValueField = "IdProvincia";
            ddlProvinciaDestino.DataBind();

            conexionProvDestino.Close();
        }

        private void cargarLocalidadFinal()
        {
            SqlConnection LocalidadDestino = new SqlConnection(conexion);
            LocalidadDestino.Open();

            SqlCommand comandoLogDestino = new SqlCommand(consultalocalidades, LocalidadDestino);
            SqlDataReader lectorLogDestino = comandoLogDestino.ExecuteReader();

            ddlLocalidadDestino.DataSource = lectorLogDestino;
            ddlLocalidadDestino.DataTextField = "NombreLocalidad";
            ddlLocalidadDestino.DataValueField = "IdLocalidad";
            ddlLocalidadDestino.DataBind();

            LocalidadDestino.Close();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarProvinciaInicio();

                cargarLocalidadInicio();

                cargarProvinciaFinal();

                cargarLocalidadFinal();
            }
        }
    }
}