using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // Biblioteca de acesso ao SQL Server
using DAL.Model;

namespace DAL.Persistence
{
    public class UsuarioDAL : Conexao
    {
        // Metodo para gravar dados: Create
        public void GravarUsuario(Usuario u)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("insert into Usuario (NomeUsuario, Email, Senha) values(@v1, @v2, @v3)", Con);

                Cmd.Parameters.AddWithValue("@v1", u.NomeUsuario);
                Cmd.Parameters.AddWithValue("@v2", u.Email);
                Cmd.Parameters.AddWithValue("@v3", u.Senha);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao gravar Usuário: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para atualizar dados: Update
        public void AtualizarUsuario(Usuario u)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("update Usuario set NomeUsuario=@v1, Email=@v2, Senha=@v3 where CodUsuario=@v4", Con);

                Cmd.Parameters.AddWithValue("@v1", u.NomeUsuario);
                Cmd.Parameters.AddWithValue("@v2", u.Email);
                Cmd.Parameters.AddWithValue("@v3", u.Senha);
                Cmd.Parameters.AddWithValue("@v4", u.CodUsuario);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao atualizar o usuário" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para excluir dados: Delete
        public void ExcluirUsuario(int CodUsuario)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("delete from Usuario where CodUsuario=@v1", Con);

                Cmd.Parameters.AddWithValue("@v1", CodUsuario);

                Cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception("Errou ao exluir usuário" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para obter usuario por ID (chave primária)

        public Usuario PesquisarUsuarioPorCodigo(string Email, string Senha)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Usuario WHERE Email=@v1 and Senha=@v2", Con);

                Cmd.Parameters.AddWithValue("@v1", Email);
                Cmd.Parameters.AddWithValue("@v2", Senha);
                Dr = Cmd.ExecuteReader(); // incluir no CartaDAL e BaralhoDAL

                Usuario u = null;

                if (Dr.Read())
                {
                    u = new Usuario();
                    
                    u.Email = Convert.ToString(Dr["Email"]);
                    u.Senha = Convert.ToString(Dr["Senha"]);
                }

                return u;

            }
            catch (Exception ex)
            {

                throw new Exception("" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para listar Usuarios
        public List<Usuario> ListarUsuarios()
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Usuario", Con);
                Dr = Cmd.ExecuteReader();

                List<Usuario> lista = new List<Usuario>(); // lista vazia

                while (Dr.Read())
                {
                    Usuario u = new Usuario();

                    u.CodUsuario = Convert.ToInt32(Dr["CodUsuario"]);
                    u.NomeUsuario = Convert.ToString(Dr["NomeUsuario"]);
                    u.Email = Convert.ToString(Dr["Email"]);

                    lista.Add(u);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception("Errou ao listar usuários" + ex.Message) ;
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
