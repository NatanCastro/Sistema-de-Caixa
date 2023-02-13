using System.Data.SQLite;
using Banco_de_dados;

namespace Sistema_de_Venda.Controller
{
    public class LoginController
    {
        Conexao Conexao = new();
        SQLiteConnection ConexaoString = Conexao.GetConnection();

        public bool VerificaLogin(string nome, string senha)
        {
            try
            {
                ConexaoString.Open();
                Conexao.sqlString = $"SELECT nome, senha FROM usuario " +
                    $"WHERE nome='{nome}' AND senha='{senha}'";
                SQLiteCommand command = new(Conexao.sqlString, ConexaoString);
                SQLiteDataReader reader = command.ExecuteReader();
                
                if (!reader.Read()) return false;
                return true;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Não foi possivel Verificar o usuario\n\n{ex.Message}");
            }
            finally
            {
                ConexaoString.Close();
            }
            return false;
        }

        public bool VerificaCadastros()
        {
            try
            {
                ConexaoString.Open();
                Conexao.sqlString = "SELECT * FROM usuario";
                SQLiteCommand command = new(Conexao.sqlString, ConexaoString);
                SQLiteDataReader reader = command.ExecuteReader();
                
                if (!reader.HasRows) return false;
                return true;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Não foi possivel verificar os usuarios cadastrados\n\n{ex.Message}");
            }
            finally
            {
                ConexaoString.Close();
            }
            return false;
        }
    }
}
