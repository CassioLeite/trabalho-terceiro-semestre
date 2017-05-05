using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // ADO.NET --> SQL Server

namespace DAL.Persistence
{
    public class Conexao
    {
        // Atributos
        protected SqlConnection Con;
        protected SqlCommand Cmd;
        protected SqlDataReader Dr;
        public const string CONNECTION_STRING = "Server=tcp:ankiservidor.database.windows.net,1433;Database=ankioab;User ID = Anki3528463; Password=Anki43241#@!$;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        // Metodo - Abrir Conexão

        protected void AbrirConexao()
        {
            try
            {
                Con = new SqlConnection(CONNECTION_STRING);
                Con.Open();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        // Metodo - Fechar Conexão

        protected void FecharConexao()
        {
            try
            {
                Con.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
