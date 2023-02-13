using System.Data.SQLite;

namespace Banco_de_dados
{
    public class Conexao
    {
        private static readonly string User = "user";
        public static SQLiteConnection Conn = new($"Data Source={Directory.GetCurrentDirectory()}; Version=3;") { };
        public string sqlString = string.Empty;

        public static SQLiteConnection GetConnection() { return Conn; }
    }
}