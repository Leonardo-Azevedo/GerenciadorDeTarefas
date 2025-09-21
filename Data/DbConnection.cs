using Microsoft.Data.SqlClient;

namespace TasksWithBD.Data
{
    public class DbConnection
    {
        SqlConnection con = new SqlConnection();

        //Construtor
        public DbConnection()
        {
            con.ConnectionString = "Data Source=DESKTOP-SR0S709;Initial Catalog=TESTE;Integrated Security=True;Trust Server Certificate=True";
        }

        //Conectar
        public SqlConnection connect()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            return con;
        }

        //Desconectar
        public void disconnect()
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
