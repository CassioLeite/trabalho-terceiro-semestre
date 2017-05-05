using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL.Model;

namespace DAL.Persistence
{
    public class CartaDAL : Conexao
    {
        // Metodo para gravar dados: Create
        public void GravarCarta(Carta c)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("insert into Carta(Frente, Verso, CodBaralho) values(@v1, @v2, @v3)", Con);

                Cmd.Parameters.AddWithValue("@v1", c.Frente);
                Cmd.Parameters.AddWithValue("@v2", c.Verso);
                Cmd.Parameters.AddWithValue("@v3", c.CodBaralho);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao gravar uma carta" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para atualizar dados: Update
        public void AtualizarCarta(Carta c)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("update Carta set Frente=@v1, Verso=@v2 where CodCarta=@v3", Con);

                Cmd.Parameters.AddWithValue("@v1", c.Frente);
                Cmd.Parameters.AddWithValue("@v2", c.Verso);
                Cmd.Parameters.AddWithValue("@v3", c.CodCarta);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Errou ao atulizar uma carta" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para excluir dados: Delete
        public void ExcluirCarta(int CodCarta)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("delete from Carta where CodCarta=@v1", Con);

                Cmd.Parameters.AddWithValue("@v1", CodCarta);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao excluir carta" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para obter carta por ID (chave primária)
        public Carta PesquisarCartaPorCodigo(int CodCarta)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Carta where CodCarta=@v1", Con);

                Cmd.Parameters.AddWithValue("@v1", CodCarta);

                Carta c = null;
                using (Dr = Cmd.ExecuteReader()) {

                    if (Dr.Read())
                    {
                        c = new Carta();

                        c.CodCarta = Convert.ToInt32(Dr["CodCarta"]);
                        c.Frente = Convert.ToString(Dr["Frente"]);
                        c.Verso = Convert.ToString(Dr["Verso"]);
                    }
                }

                return c;
            }
            catch (Exception ex)
            {

                throw new Exception("Errou ao pesquisar Carta" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public List<int> TodosOsIdsVinculadosAo(int idDoBaralho)
        {
            List<int> resultado = new List<int>();

            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT CodCarta FROM Carta WHERE CodBaralho = @idDoBaralho";
                    command.Parameters.AddWithValue("@idDoBaralho", idDoBaralho);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                resultado.Add(reader.GetInt32(0));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Erro ao listar cartas" + ex.Message);
                    }

                }
            }


            return resultado;
        }

        public MaiorEMenorId ObtemMaiorEMenorId(int idDoBaralho)
        {
            MaiorEMenorId resultado = null;
            
            using(SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                using(SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT TOP 1 MIN(CodCarta) idMenor, MAX(CodCarta) idMarior FROM Carta WHERE CodBaralho = @idDoBaralho";
                    command.Parameters.AddWithValue("@idDoBaralho", idDoBaralho);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                resultado = new MaiorEMenorId();
                                resultado.MenorId = reader.GetInt32(0);
                                resultado.MaiorId = reader.GetInt32(1);
                            }

                        }
                    } catch(Exception ex)
                    {
                        throw new Exception("Erro ao listar cartas" + ex.Message);
                    }
                    
                }
            }


            return resultado;
        }
        
        // Metodo para listar cartas
        public List<Carta> ListarCartas(int CodBaralho)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Carta where CodCarta=@v1 and CodBaralho=@v2", Con);
                Cmd.Parameters.AddWithValue("@v1", CodBaralho);

                Dr = Cmd.ExecuteReader();

                List<Carta> lista = new List<Carta>();

                while(Dr.Read())
                {
                    Carta c = new Carta();

                    c.CodCarta = Convert.ToInt32(Dr["CodCarta"]); 
                    c.Frente = Convert.ToString(Dr["Frente"]);
                    c.Verso = Convert.ToString(Dr["Verso"]);
                    c.CodCarta = Convert.ToInt32(Dr["CodBaralho"]);

                    lista.Add(c);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar cartas" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
