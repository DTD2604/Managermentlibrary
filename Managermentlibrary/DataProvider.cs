using Microsoft.Data.SqlClient;
using System.Data;

namespace Managermentlibrary
{
    public class DataProvider
    {
        private static string ConnectionString = "Data Source=msi;Initial Catalog=liraryManagements;Integrated Security=True; TrustServerCertificate=True";

        //attribute
        private static DataProvider instance;

        //singleton: exploit the characteristics of static is unique to help data security and convenient for code management
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set { instance = value; }
        }

        //contructor
        private DataProvider()
        { }

        //method
        public DataTable ExcuteQuery(string query, object[] paramerter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                if (paramerter != null)
                {
                    for (int i = 0; i < paramerter.Length; i++)
                    {
                        command.Parameters.Add(paramerter[i]);
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);

                connection.Close();

                return data;
            }
        }

        public int ExcueNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    for (int i = 0; i < parameter.Length; i++)
                    {
                        command.Parameters.Add(parameter[i]);
                    }
                    data = command.ExecuteNonQuery();

                    connection.Close();

                    return data;
                }
            }
            catch
            {
                return -1;
            }
        }

        public object ExcuteScalar(string query)
        {
            object data = null;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                data = command.ExecuteScalar();

                connection.Close();

                return data;
            }
        }
    }
}