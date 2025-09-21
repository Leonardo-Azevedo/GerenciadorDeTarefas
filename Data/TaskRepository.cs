using Microsoft.Data.SqlClient;
using TasksWithBD.Entities;
using TasksWithBD.Entities.Enums;
using TasksWithBD.Entities.Interfaces;

namespace TasksWithBD.Data
{
    public class TaskRepository()
    {
        //SqlCommand cmd = new SqlCommand();
        DbConnection connection = new DbConnection();
        string message = "";

        private ITask MapTask(SqlDataReader reader)
        {
            var task = new SimpleTask(
                name: reader["Name"].ToString(),
                description: reader["Description"].ToString(),
                createDate: (DateTime)reader["CreateDate"],
                startDate: (DateTime)reader["StartDate"],
                finishDate: reader["FinishDate"] == DBNull.Value ? (DateTime?)null : (DateTime)reader["FinishDate"],
                status: (OrderStatus)(int)reader["Status"]

            );

            return task;
        }
        public void Add(ITask task)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO Tasks (Name, Description, CreateDate, StartDate, Status) VALUES (@Name, @Description, @CreateDate, @StartDate, @Status)";

            cmd.Parameters.AddWithValue("@Name", task.Name);
            cmd.Parameters.AddWithValue("@Description", task.Description);
            cmd.Parameters.AddWithValue("@CreateDate", task.CreateDate.Date);
            cmd.Parameters.AddWithValue("@StartDate", task.StartDate.Date);
            cmd.Parameters.AddWithValue("@Status", (int)task.Status);

            try
            {
                //conectar no banco
                cmd.Connection = connection.connect();
                //executar o comando
                cmd.ExecuteNonQuery();
                //desconectar do banco
                connection.disconnect();
                //mostrar mensagem
                this.message = "Registered task!";
                //clear parameters
                cmd.Parameters.Clear();

            }
            catch (Exception ex)
            {
                this.message = "Error!";
                //clear parameters
                cmd.Parameters.Clear();
            }

        }

        public IEnumerable<ITask> ListAll()
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT Name, Description, CreateDate, StartDate, FinishDate, Status FROM Tasks ORDER BY Id DESC";
            List<ITask> list = new List<ITask>();

            try
            {
                //conectar no banco
                cmd.Connection = connection.connect();
                //executar o comando
                SqlDataReader reader = cmd.ExecuteReader();
                //percorrer a listagem
                while(reader.Read())
                {
                    list.Add(MapTask(reader));
                }
                reader.Close();
                //desconectar do banco
                connection.disconnect();
                //mostrar mensagem

            }
            catch (Exception ex)
            {
                this.message = "Error!";
                //clear parameters
                cmd.Parameters.Clear();
            }

            return list;
        }

        public void Delete(int id)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "DELETE FROM Tasks WHERE Id = @Id";

            cmd.Parameters.AddWithValue("@Id", id);

            try
            {
                //conectar no banco
                cmd.Connection = connection.connect();
                //executar o comando
                cmd.ExecuteNonQuery();
                //desconectar do banco
                connection.disconnect();
                //mostrar mensagem
                this.message = "Task Deleted!";
                //clear parameters
                cmd.Parameters.Clear();

            }
            catch (Exception ex)
            {
                this.message = "Error!";
            }
        }

        public void Update(ITask task)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UPDATE Tasks SET Name=@Name, Description=@Description, StartDate=@StartDate, FinishDate=@FinishDate, Status=@Status WHERE Id=@Id";

            cmd.Parameters.AddWithValue("@Name", task.Name);
            cmd.Parameters.AddWithValue("@Description", task.Description);
            cmd.Parameters.AddWithValue("@StartDate", task.StartDate.Date);
            cmd.Parameters.AddWithValue("@FinishDate", task.FinishDate.HasValue ? (object)task.FinishDate.Value.Date : DBNull.Value);
            cmd.Parameters.AddWithValue("@Status", (int)task.Status);
            cmd.Parameters.AddWithValue("@Id", task.Id);

            try
            {
                //conectar no banco
                cmd.Connection = connection.connect();
                //executar o comando
                cmd.ExecuteNonQuery();
                //desconectar do banco
                connection.disconnect();
                //mostrar mensagem
                this.message = "Task Updated!";
                //clear parameters
                cmd.Parameters.Clear();

            }
            catch (Exception ex)
            {
                this.message = "Error!";
            }
        }

        public ITask GetTaskById(int id)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM Tasks WHERE Id = @Id";

            cmd.Parameters.AddWithValue("Id", id);

            try
            {
                //conectar no banco
                cmd.Connection = connection.connect();
                //executar o comando
                SqlDataReader reader = cmd.ExecuteReader();
                //percorrer a listagem
                if(reader.Read())
                {
                    ITask task = new SimpleTask();
                    task = MapTask(reader);
                    reader.Close();
                    connection.disconnect();
                    cmd.Parameters.Clear();
                    return task;

                }
                else
                {
                    cmd.Parameters.Clear();
                    reader.Close();
                    connection.disconnect();
                    return null;
                }

            }
            catch (Exception ex)
            {
                this.message = "Error!";
                //clear parameters
                cmd.Parameters.Clear();
                return null;
            }

        }
    
        
    }
}
