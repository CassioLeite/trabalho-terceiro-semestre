using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL.Model;

namespace DAL.Persistence
{
    public class BaralhoDAL : Conexao
    {
        public int CodCarta { get; set; }
        public string Frente { get; set; }
        public string Verso { get; set; }



        // Metodo para gravar dados: Create
        public void GravarBaralho(Baralho b)
        {
            int id = 0;
            bool baralhoJaExiste = false;

            AbrirConexao();
            Cmd = new SqlCommand("select CodBaralho from Baralho where NomeBaralho=@v1", Con);
            Cmd.Parameters.AddWithValue("@v1", b.NomeBaralho);
            using (SqlDataReader dr = Cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    id = dr.GetInt32(0);
                    baralhoJaExiste = true;
                }
            }

            if (!baralhoJaExiste)
            {
                try
                {
                    AbrirConexao();
                    //Cmd = new SqlCommand("insert into Baralho(NomeBaralho) OUTPUT INSERTED.CodBaralho values(@v1)", Con);
                    Cmd = new SqlCommand("insert into Baralho(NomeBaralho) values(@v1)", Con);
                    Cmd.Parameters.AddWithValue("@v1", b.NomeBaralho);
                    Cmd.ExecuteScalar();

                }
                catch (Exception ex)
                {

                    throw new Exception("Erro ao gravar um Baralho" + ex.Message);
                }
                finally
                {
                    FecharConexao();
                }

                try
                {
                    AbrirConexao();
                    Cmd = new SqlCommand("select CodBaralho from Baralho where NomeBaralho=@v1", Con);
                    Cmd.Parameters.AddWithValue("@v1", b.NomeBaralho);
                    using (SqlDataReader dr = Cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            id = dr.GetInt32(0);
                            baralhoJaExiste = true;
                        }
                    }
                    Cmd = new SqlCommand("insert into Carta(Frente, Verso, CodBaralho) values(@v1, @v2, @v3)", Con);

                    Cmd.Parameters.AddWithValue("@v1", Frente);
                    Cmd.Parameters.AddWithValue("@v2", Verso);
                    Cmd.Parameters.AddWithValue("@v3", id.ToString());
                    Cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    throw new Exception("Erro ao gravar uma Carta" + ex.Message);
                }
                finally
                {
                    FecharConexao();
                }
            }
            
            else
            {
                try
                {
                    Cmd = new SqlCommand("insert into Carta(Frente, Verso, CodBaralho) values(@v1, @v2, @v3)", Con);

                    Cmd.Parameters.AddWithValue("@v1", Frente);
                    Cmd.Parameters.AddWithValue("@v2", Verso);
                    Cmd.Parameters.AddWithValue("@v3", id.ToString());
                    Cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    throw new Exception("Erro ao gravar uma Carta" + ex.Message);
                }
                finally
                {
                    FecharConexao();
                }
            }

            /*
            try
            {

                AbrirConexao();
                bool cartaJaExiste = false;
                Cmd = new SqlCommand("select top 1 1 from Carta where CodBaralho=@v3", Con);
                Cmd.Parameters.AddWithValue("@v3", id);
                using (SqlDataReader dr = Cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        cartaJaExiste = true;
                    }
                }

                if (cartaJaExiste)
                {
                    Cmd = new SqlCommand("update Carta set Frente=@v1, Verso=@v2 where CodBaralho=@v3", Con);

                    Cmd.Parameters.AddWithValue("@v1", Frente);
                    Cmd.Parameters.AddWithValue("@v2", Verso);
                    Cmd.Parameters.AddWithValue("@v3", id);
                    Cmd.ExecuteNonQuery();
                }
                else
                {
                    Cmd = new SqlCommand("insert into Carta(Frente, Verso, CodBaralho) values(@v1, @v2, @v3)", Con);

                    Cmd.Parameters.AddWithValue("@v1", Frente);
                    Cmd.Parameters.AddWithValue("@v2", Verso);
                    Cmd.Parameters.AddWithValue("@v3", id.ToString());
                }

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

    */

        }

        // Metodo para atualizar dados: Update
        public void AtualizarBaralho(Baralho b)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("update Baralho set NomeBaralho=@v1 where CodBaralho=@v2", Con);

                Cmd.Parameters.AddWithValue("@v1", b.NomeBaralho);
                Cmd.Parameters.AddWithValue("@v2", b.CodBaralho);

                Cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao atualizar Baralho" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para excluir dados: Delete
        public void ExcluirBaralho(int CodBaralho)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("delete from Baralho where CodBaralho=@v1", Con);

                Cmd.Parameters.AddWithValue("@v1", CodBaralho);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao excluir Baralho" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para obter baralho por ID (chave primária)
        public Baralho PesquisarBaralhoPorCodigo(int CodBaralho)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Baralho where CodBaralho=@v1", Con);
                Cmd.Parameters.AddWithValue("@v1", CodBaralho);
                Dr = Cmd.ExecuteReader();

                Baralho b = null;

                if (Dr.Read())
                {
                    b = new Baralho();

                    b.CodBaralho = Convert.ToInt32(Dr["CodBaralho"]);
                    b.NomeBaralho = Convert.ToString(Dr["NomeBaralho"]);
                }

                return b;

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao pesquisar baralho" + ex.Message);
            }
        }

        // Metodo para listar baralhos
        public List<Baralho> ListarBaralhos()
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Baralho", Con);
                Dr = Cmd.ExecuteReader();

                List<Baralho> lista = new List<Baralho>();

                while (Dr.Read())
                {
                    Baralho b = new Baralho();

                    b.CodBaralho = Convert.ToInt32(Dr["CodBaralho"]);
                    b.NomeBaralho = Convert.ToString(Dr["NomeBaralho"]);

                    lista.Add(b);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel listar os baralhos" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }



    }
}
