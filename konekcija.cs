using System.Data;
using System.Data.SqlClient;

namespace KontrolniA {
    class Konekcija {
        static string connectionString = "Integrated Security=SSPI; Initial Catalog=Hotel; Data Source=.\\SQLEXPRESS";

        public static SqlConnection GetConnection() {
            return new SqlConnection(connectionString);
        }

        public static SqlCommand GetCommand() {
            var cmd = new SqlCommand();
            cmd.Connection = GetConnection();
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd;
        }
    }
}
