using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Model;
using DAL.Persistence;
using System.Data.SqlClient;

namespace website.Pages
{
    public partial class Baralhos : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
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

                try
                {
                    BaralhoDAL d = new BaralhoDAL();

                    gridBaralhos.DataSource = d.ListarBaralhos(); // popular o grid;
                    gridBaralhos.DataBind();
                }
                catch (Exception ex)
                {

                    lblMensagem.Text = ex.Message;
                }
            }
            
        }

        protected void gdvUsuarios_RowEditig(object sender, GridViewEditEventArgs e)
        {
            //gridBaralhos.EditIndex = e.NewEditIndex;

        }

        protected void gdvUsuarios_RowEdDeletig(object sender, GridViewEditEventArgs e)
        {

        }

        protected void gdvUsuarios_RowUpdatig(object sender, GridViewEditEventArgs e)
        {

        }

        protected void gdvUsuarios_RowCanceligEdit(object sender, GridViewEditEventArgs e)
        {

        }
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


        protected void gridBaralhos_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void gridBaralhos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void gridBaralhos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }

        protected void btnDeletar_Click(object sender, EventArgs e)
        {
            
        }

        protected void gridBaralhos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int CodBaralho = Convert.ToInt32(gridBaralhos.DataKeys[e.RowIndex].Value.ToString());

            Baralho b = new Baralho();
            BaralhoDAL Baralho = new BaralhoDAL();
            Baralho.ExcluirBaralho(CodBaralho);
            gridBaralhos.DataSource = Baralho.ListarBaralhos(); // popular o grid;
            gridBaralhos.DataBind();
        }
    }
}