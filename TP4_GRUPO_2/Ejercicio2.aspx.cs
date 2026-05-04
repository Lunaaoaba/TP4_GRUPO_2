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
        private const string conexionNeptuno = @"Data Source=localhost\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True;Encrypt=False";
        private string consultaBdd = "SELECT IdProducto, NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad FROM Productos";


        private void CargarTablaProductos()
        {
            
            SqlConnection conexion = new SqlConnection(conexionNeptuno);
            conexion.Open();

            SqlCommand comando = new SqlCommand(consultaBdd, conexion);
            SqlDataReader lector = comando.ExecuteReader();

            gvProductos.DataSource = lector;
            gvProductos.DataBind();

            conexion.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlProducto.Items.Add(new ListItem("Igual a: ", "="));
                ddlProducto.Items.Add(new ListItem("Mayor a: ", ">"));
                ddlProducto.Items.Add(new ListItem("Menor a: ", "<"));

                ddlCategoria.Items.Add(new ListItem("Igual a: ", "="));
                ddlCategoria.Items.Add(new ListItem("Mayor a: ", ">"));
                ddlCategoria.Items.Add(new ListItem("Menor a: ", "<"));

                CargarTablaProductos();
            }
        }

        protected void btnFiltro_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(txtIdProducto.Text) && string.IsNullOrEmpty(txtCategoria.Text))
            {
                consultaBdd = "SELECT IdProducto, NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad FROM Productos WHERE IdProducto" + ddlProducto.SelectedValue + txtIdProducto.Text;

            }
            else if (string.IsNullOrEmpty(txtIdProducto.Text) && !string.IsNullOrEmpty(txtCategoria.Text))
            {
                consultaBdd = "SELECT IdProducto, NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad FROM Productos WHERE IdCategoría" + ddlCategoria.SelectedValue + txtCategoria.Text;
            }
            else if (!string.IsNullOrEmpty(txtIdProducto.Text) && !string.IsNullOrEmpty(txtCategoria.Text))
            {
                consultaBdd = "SELECT IdProducto, NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad FROM Productos WHERE IdProducto" + ddlProducto.SelectedValue + txtIdProducto.Text + " AND IdCategoría" + ddlCategoria.SelectedValue + txtCategoria.Text;
            } 

            SqlConnection conexion = new SqlConnection(conexionNeptuno);
            conexion.Open();

            SqlCommand comando = new SqlCommand(consultaBdd, conexion);
            SqlDataReader lector = comando.ExecuteReader();

            gvProductos.DataSource = lector;
            gvProductos.DataBind();

            conexion.Close();

            txtIdProducto.Text = string.Empty;
            txtCategoria.Text = string.Empty;
            ddlProducto.SelectedIndex = 0;
            ddlCategoria.SelectedIndex = 0;
        }

        protected void btQuitarFiltro_Click(object sender, EventArgs e)
        {
            CargarTablaProductos();
        }

        protected void cverrores_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (!string.IsNullOrEmpty(txtIdProducto.Text) && string.IsNullOrEmpty(txtCategoria.Text))
            {
                args.IsValid = true;
                lberrorfiltro.Visible = false;
            }
            else if(string.IsNullOrEmpty(txtIdProducto.Text) && !string.IsNullOrEmpty(txtCategoria.Text))
            {
                args.IsValid = true;
                lberrorfiltro.Visible = false;
            }
            else if (!string.IsNullOrEmpty(txtIdProducto.Text) && !string.IsNullOrEmpty(txtCategoria.Text))
            {
                args.IsValid = true;
                lberrorfiltro.Visible = false;
            }
            else
            {
                args.IsValid = false;
                lberrorfiltro.Text = "Debe ingresar al menos un filtro para aplicar la búsqueda.";
            }
        }
    }
}