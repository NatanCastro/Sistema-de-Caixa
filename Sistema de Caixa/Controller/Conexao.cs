using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Caixa.Controller
{
    public class Conexao
    {
        private static readonly string User = "user";
        public static SQLiteConnection Conn = new($"Data Source=C:/Users/{User}/source/repos/natan22gt/Sistema-de-Caixa/Sistema de Caixa/banco/caixa.sqlite3; Version=3;") { };
        public string sqlString = string.Empty;

        public static SQLiteConnection GetConnection() { return Conn; }

        //public string GetSql()
        //{
        //    return sqlString;
        //}
        //public void SetSql(string sql)
        //{
        //    sqlString = sql;
        //}
    }
}
