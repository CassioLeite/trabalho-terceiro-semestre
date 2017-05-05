using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Model;
using DAL.Persistence;

namespace website.Pages
{
    public partial class CartaNext : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                IdDoBaralho();

                if (CarregarCarta() != 0)
                {
                    CarregarCarta();
                }
            }

        }

        private int? IdDoBaralho()
        {
            int id;

            if (int.TryParse(Request.QueryString["CodBaralho"], out id))
            {
                return id;
            }

            return null;
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

        protected void btnNextCarta_Click(object sender, EventArgs e)
        {
            CarregarCarta();
            btnVerVerso.Visible = true;
        }

        private int CarregarCarta()
        {
            int idAleatorio = 0;
            int? idDoBaralho = IdDoBaralho();

            if (idDoBaralho != null)
            {
                CartaDAL dal = new CartaDAL();
                List<int> ids = dal.TodosOsIdsVinculadosAo(idDoBaralho.Value);
                MaiorEMenorId maiorEMenor = dal.ObtemMaiorEMenorId(idDoBaralho.Value);
                //int idAleatorio = 0;

                while (true){
                    Random aletorio = new Random();
                    idAleatorio = aletorio.Next(maiorEMenor.MenorId, maiorEMenor.MaiorId);

                    if (ids.Contains(idAleatorio))
                    {
                        break;
                    }
                }

                Carta carta = new CartaDAL().PesquisarCartaPorCodigo(idAleatorio);
                lblFrente.Text = carta.Frente;
                lblVerso.Text = carta.Verso;
                EsconderVerso();

            }


            return idAleatorio;
        }

        protected void ExibirLinha()
        {
            lblLinha.Text = "---------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            lblLinha.Visible = true;

        }
        protected void btnVerVerso_Click(object sender, EventArgs e)
        {
            ExibirVerso();
            btnNextCarta.Visible = true;
            ExibirLinha();
            btnVerVerso.Visible = false;

        }

        protected void EsconderVerso()
        {
            lblVerso.Visible = false;
            btnNextCarta.Visible = false;
        }

        protected void ExibirVerso()
        {
            lblVerso.Visible = true;
        }

        protected void btnDeletarCarta_Click(object sender, EventArgs e)
        {
            //int idCarta = CarregarCarta();
            Carta c = new Carta();
            CartaDAL carta = new CartaDAL();

            carta.ExcluirCarta(CarregarCarta());
            Response.Redirect("Baralhos.aspx");
            //CarregarCarta();
            //btnVerVerso.Visible = true;


        }

        protected void btnEditarCarta_Click(object sender, EventArgs e)
        {

        }
    }
}