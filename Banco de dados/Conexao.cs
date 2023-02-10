using System.Data.SQLite;

namespace Banco_de_dados
{
    public class Conexao
    {
        private static readonly string User = "natan.gacastro";
        public static SQLiteConnection Conn = new($"Data Source=C:/Users/{User}/source/repos/natan22gt/Sistema-de-Caixa/Banco de dados/caixa.sqlite3; Version=3;") { };
        public string sqlString = string.Empty;

        public static SQLiteConnection GetConnection() { return Conn; }
    }
}