using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;

namespace BibliotecaEstoque.Database
{
    public class LocalDbClass
    {
        public string connection;
        public SqlConnection sqlConnection;

        public LocalDbClass() {
            try 
            {

                connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bruno Forgiarini\Documents\code\C#\WindowsForms\Controle de Estoque\BibliotecaEstoque\Database\database.mdf;Integrated Security=True";
                // string databasePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "database.mdf");
                //connection = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databasePath};Integrated Security=True";

                sqlConnection = new SqlConnection(connection);
                sqlConnection.Open();
            }
            catch 
            { 
                throw new Exception("Erro ao conectar com o banco de dados");
            }
            
        }        

        public DataTable DataTable(string SQL) 
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand sqlCommand = new SqlCommand(SQL, sqlConnection);
                sqlCommand.CommandTimeout = 0;
                var reader = sqlCommand.ExecuteReader();
                dt.Load(reader);
            }
            catch 
            {
                throw new Exception("Erro ao executar comando");
            }

            return dt;
        }

        public string SQLCommand(string SQL) 
        {
            try 
            {
                SqlCommand sqlCommand = new SqlCommand(SQL, sqlConnection);
                sqlCommand.CommandTimeout = 0;
                var reader = sqlCommand.ExecuteReader();
                return "Comando executado com sucesso";
            }
            catch 
            {
                throw new Exception("Erro ao executar comando");
            }
        }
       
        public void Close() 
        {
            sqlConnection.Close();
        }
    }
}
