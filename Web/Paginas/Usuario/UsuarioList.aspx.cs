using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Paginas.Usuario
{
    public partial class UsuarioList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!Page.IsPostBack)
            {
                CargarLista();
            }
            //btnCargarLista_Click(btnCargarLista, new EventArgs());

        }

        void CargarLista()
        {
            Web.Logic.Clases.UsuarioClass objUsuarioClass = new Web.Logic.Clases.UsuarioClass();
            GridView1.DataSource = objUsuarioClass.GetAllUsuario();
            GridView1.DataBind();
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            
            int indice = Convert.ToInt32(e.CommandArgument);
            //Console.WriteLine("GridView1_RowCommand "+ indice.ToString());
            if (e.CommandName == "Modificar")
            {

                txtIdUsuario.Text = ((Label)GridView1.Rows[indice].FindControl("lblIdUsuario")).Text;
                HiddenField1.Value = txtIdUsuario.Text;
                txtUsuario.Text = GridView1.Rows[indice].Cells[1].Text;
                txtPassword.Text = GridView1.Rows[indice].Cells[2].Text;
                txtPerfil.Text = GridView1.Rows[indice].Cells[3].Text;
                if (GridView1.Rows[indice].Cells[4].Text == "false")
                {
                    chbxEstado.Checked = false;
                }
                else
                {
                    chbxEstado.Checked = true;
                }
            }
            else if (e.CommandName == "Eliminar") {
                Web.Logic.Clases.UsuarioClass objUsuarioClass = new Web.Logic.Clases.UsuarioClass();
                string id= ((Label)GridView1.Rows[indice].FindControl("lblIdUsuario")).Text;
                objUsuarioClass.DeleteUsuario(Convert.ToInt32(id));
                CargarLista();
            }
        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                Web.Logic.Clases.UsuarioClass objUsuarioClass = new Web.Logic.Clases.UsuarioClass();
                if (HiddenField1.Value!="")
                {
                    objUsuarioClass.UpdateUsuario(Convert.ToInt32(txtIdUsuario.Text), txtUsuario.Text, txtPassword.Text, txtPerfil.Text, chbxEstado.Checked, "admin", DateTime.Now);
                }
                else
                {
                    objUsuarioClass.InsertUsuario( txtUsuario.Text, txtPassword.Text, txtPerfil.Text, chbxEstado.Checked, "admin", DateTime.Now);
                }
                CargarLista();

            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            HiddenField1.Value = "";
        }

        protected void btnCargar_Click(object sender, EventArgs e)
        {
            CargarLista();
        }
    }
}