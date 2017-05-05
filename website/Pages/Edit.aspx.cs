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
    public partial class Edit : System.Web.UI.Page
    {
        //Page Load
        protected void Page_Load(object sender, EventArgs e)
        {
            // Tenta obter o cookie do cliente
            HttpCookie cookie = Request.Cookies["token"];

            if (cookie == null)
            {
                // O cookie não existe!

                // O return encerra a execução por aqui
                Response.Redirect("../Default.aspx");
                return;
            }

            // A partir daqui, a variável cookie contém o cookie, e seu valor está em cookie.Value
            if (cookie.Value != "valorAleatorio")
            {
                Response.Redirect("../Default.aspx");
                return;
            }
        }

        //Botão de Logout
        protected void Unnamed_Click(object sender, EventArgs e)
        {
            // Cria um cookie do lado do servidor
            HttpCookie cookie = new HttpCookie("token", "");

            // Define a validade do cookie (10 dias a partir de hoje)
            cookie.Expires = DateTime.Now.AddDays(-10);

            // Envia o cookie para o cliente
            Response.Cookies.Set(cookie);

            Response.Redirect("../Default.aspx");
        }

        //Botão Cadastrar
        protected void btnCadastroBaralho_Click(object sender, EventArgs e)
        {
            try
            {
                
                

                Baralho b = new Baralho();

                b.NomeBaralho = txtNomeBaralho.Text;

                BaralhoDAL p = new BaralhoDAL();
                p.Frente = txtFrente.Text;
                p.Verso = txtVerso.Text;

                p.GravarBaralho(b);

                txtFrente.Text = String.Empty;
                txtVerso.Text = String.Empty;

            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }

        }
    }
}