using Microsoft.Data.SqlClient;

namespace TasksWithBD.Data
{
    public class DbConnection
    {
        SqlConnection con = new SqlConnection();

        //Construtor
        public DbConnection()
        {
            con.ConnectionString = "Data Source=DESKTOP-VJBNCBH;Initial Catalog=TESTE;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
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
