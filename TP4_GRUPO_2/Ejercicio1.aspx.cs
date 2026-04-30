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
            string valor = ddlProvincia.SelectedValue.ToString();
            SqlConnection conexionbasededatos = new SqlConnection(conexion);
            conexionbasededatos.Open();

            SqlCommand comandobasededatos = new SqlCommand(consultaprovincias, conexionbasededatos);
            SqlDataReader lectorbasededatos = comandobasededatos.ExecuteReader();

            ddlProvincia.Items.Clear();
            ddlProvincia.Items.Add(new ListItem("Seleccione una provincia", "0"));
            while (lectorbasededatos.Read())
            {
                if (lectorbasededatos["IdProvincia"].ToString() != ddlProvinciaDestino.SelectedValue.ToString())
                {
                    ddlProvincia.Items.Add(new ListItem(lectorbasededatos["NombreProvincia"].ToString(), lectorbasededatos["IdProvincia"].ToString()));
                }
            }

            if (valor != "0")
            {
                ddlProvincia.SelectedValue = valor;
            }

            conexionbasededatos.Close();
        }
        private void cargarLocalidadInicio()
        {
            SqlConnection conexionLocalidad = new SqlConnection(conexion);
            conexionLocalidad.Open();

            SqlCommand comandoLocalidad = new SqlCommand(consultalocalidades, conexionLocalidad);
            SqlDataReader lectorLocalidad = comandoLocalidad.ExecuteReader();
            
            ddlLocalidad.Items.Clear();
            ddlLocalidad.Items.Add(new ListItem("Seleccione una localidad", "0"));
            while (lectorLocalidad.Read())
            {
                if (lectorLocalidad["IdProvincia"].ToString() == ddlProvincia.SelectedValue.ToString())
                {
                    ddlLocalidad.Items.Add(new ListItem(lectorLocalidad["NombreLocalidad"].ToString()));
                }
            }


            conexionLocalidad.Close();
        }

        private void cargarProvinciaDestino()
        {
            string valor = ddlProvinciaDestino.SelectedValue.ToString();
            SqlConnection conexionProvDestino = new SqlConnection(conexion);
            conexionProvDestino.Open();

            SqlCommand comandoProvDestino = new SqlCommand(consultaprovincias, conexionProvDestino);
            SqlDataReader lectorProvDestino = comandoProvDestino.ExecuteReader();

            ddlProvinciaDestino.Items.Clear();
            ddlProvinciaDestino.Items.Add(new ListItem("Seleccione una provincia", "0"));
            while (lectorProvDestino.Read())
            {
                if (lectorProvDestino["IdProvincia"].ToString() != ddlProvincia.SelectedValue.ToString())
                {
                     ddlProvinciaDestino.Items.Add(new ListItem(lectorProvDestino["NombreProvincia"].ToString(), lectorProvDestino["IdProvincia"].ToString()));
                }
            }

                if(valor != "0")
                {
                    ddlProvinciaDestino.SelectedValue = valor;
                }
            conexionProvDestino.Close();
        }

        private void cargarLocalidadDestino()
        {
            SqlConnection conexionLocalidadDestino = new SqlConnection(conexion);
            conexionLocalidadDestino.Open();

            SqlCommand comandoLocalidadDestino = new SqlCommand(consultalocalidades, conexionLocalidadDestino);
            SqlDataReader lectorLocalidadDestino = comandoLocalidadDestino.ExecuteReader();

            ddlLocalidadDestino.Items.Clear();

            ddlLocalidadDestino.Items.Add(new ListItem("Seleccione una localidad", "0"));
            while (lectorLocalidadDestino.Read())
            {
                if (lectorLocalidadDestino["IdProvincia"].ToString() == ddlProvinciaDestino.SelectedValue.ToString())
                {
                    ddlLocalidadDestino.Items.Add(new ListItem(lectorLocalidadDestino["NombreLocalidad"].ToString()));
                }
            }
           

            conexionLocalidadDestino.Close();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {   
                cargarProvinciaInicio();

                cargarProvinciaDestino();

                cargarLocalidadInicio();

                cargarLocalidadDestino();
            }
        }

        protected void ddlProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarLocalidadInicio();
            cargarProvinciaDestino();
        }

        protected void ddlProvinciaDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarLocalidadDestino();
            cargarProvinciaInicio();
        }
    }
}