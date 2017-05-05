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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            // Tenta obter o cookie do cliente
            HttpCookie cookie = Request.Cookies["token"];

            if (cookie == null)
            {
                // O cookie não existe!

                // O return encerra a execução por aqui
                return;
            }

            // A partir daqui, a variável cookie contém o cookie, e seu valor está em cookie.Value

            if (cookie.Value == "valorAleatorio")
            {
                Response.Redirect("Itens.aspx", true);
            }

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string Email = Convert.ToString(txtEmail.Text);
                string Senha = Convert.ToString(txtSenha.Text);


                UsuarioDAL u = new UsuarioDAL();

                Usuario p = u.PesquisarUsuarioPorCodigo(Email, Senha);

                if(p != null){

                    // Cria um cookie do lado do servidor
                    HttpCookie cookie = new HttpCookie("token", "valorAleatorio");

                    // Define a validade do cookie (10 dias a partir de hoje)
                    cookie.Expires = DateTime.Now.AddDays(10);

                    // Envia o cookie para o cliente
                    Response.Cookies.Set(cookie);
                    
                    Response.Redirect("Itens.aspx");

                }

            }


            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }
    }
}