using Microsoft.Data.SqlClient;

namespace Managermentlibrary.IUD_Data
{
    public class IUD_DataCategories
    {
        private static IUD_DataCategories instance;

        public static IUD_DataCategories Instance
        {
            get { if (instance == null) instance = new IUD_DataCategories(); return instance; }
            private set => instance = value;
        }

        private IUD_DataCategories()
        { }

        public int Insert(string id, string name, string Description)
        {
            string query = $"insert into dbo.Categories values( @ID , @Name , @Description )";

            SqlParameter paraID = new SqlParameter("@ID", id);
            SqlParameter paraName = new SqlParameter("@Name", name);
            SqlParameter paraDescription = new SqlParameter("@Description", Description);

            SqlParameter[] sqlParameters = { paraID, paraName, paraDescription };

            return DataProvider.Instance.ExcueNonQuery(query, sqlParameters);
        }

        public int Update(string id, string name, string Description)
        {
            string query = $"update dbo.Categories set Name = @Name ,Description = @Description where ID = @Id ";

            SqlParameter paraId = new SqlParameter("@Id", id);
            SqlParameter paraName = new SqlParameter("@Name", name);
            SqlParameter paraDescription = new SqlParameter("@Description", Description);
            SqlParameter[] sqlParameters = { paraId, paraName, paraDescription};

            return DataProvider.Instance.ExcueNonQuery(query, sqlParameters);
        }

        public int Delete(string id)
        {
            string query = "delete Categories where ID = @id ";

            SqlParameter paraId = new SqlParameter("@id", id);
            SqlParameter[] parameters = { paraId };

            return DataProvider.Instance.ExcueNonQuery(query, parameters);
        }
    }
}