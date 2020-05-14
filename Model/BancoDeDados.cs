using System.Windows.Forms;
using System.Data.SqlClient;

namespace Model
{
    public class BancoDeDados
    {
        public static string StringConexao = @"Data Source=DESKTOP-77K5RRQ\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static SqlConnection Conexao = new SqlConnection(StringConexao);
    }
}
