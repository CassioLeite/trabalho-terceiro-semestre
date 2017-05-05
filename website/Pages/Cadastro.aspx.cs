using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using DAL.Model;
using DAL.Persistence;

namespace website.Pages
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario u = new Usuario();

                u.NomeUsuario = txtNome.Text;
                u.Email = txtEmail.Text;
                u.Senha = txtSenha.Text;

                UsuarioDAL p = new UsuarioDAL();

                p.GravarUsuario(u);

                Response.Redirect("Redirect.aspx"); 
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }
    }
}