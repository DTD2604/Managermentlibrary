using Microsoft.Data.SqlClient;

namespace Managermentlibrary.IUD_Data
{
    public class IUD_DataBook
    {
        private static IUD_DataBook instance;

        public static IUD_DataBook Instance
        {
            get { if (instance == null) instance = new IUD_DataBook(); return instance; }
            private set => instance = value;
        }

        private IUD_DataBook()
        { }

        public int Insert(string id, string name, string idAuthor, string idCatergories)
        {
            string query = $"insert into Books values( @ID , @Name , @IdCatergories , @IdAuthor )";

            SqlParameter paraID = new SqlParameter("@ID", id);
            SqlParameter paraName = new SqlParameter("@Name", name);
            SqlParameter paraIdCatergories = new SqlParameter("@IdCatergories", idCatergories);
            SqlParameter paraIdAuthor = new SqlParameter("@IdAuthor", idAuthor);
            SqlParameter[] sqlParameters = { paraID, paraName, paraIdCatergories, paraIdAuthor };

            return DataProvider.Instance.ExcueNonQuery(query, sqlParameters);
        }

        public int Update(string id, string name, string idAuthor, string idCatergories)
        {
            string query = $"update Books set Name = @Name , IdCatergories = @IdCatergories , IdAuthor = @IdAuthor where ID = @Id ";

            SqlParameter paraID = new SqlParameter("@ID", id);
            SqlParameter paraName = new SqlParameter("@Name", name);
            SqlParameter paraIdCatergories = new SqlParameter("@IdCatergories", idCatergories);
            SqlParameter paraIdAuthor = new SqlParameter("@IdAuthor", idAuthor);
            SqlParameter[] sqlParameters = { paraID, paraName, paraIdCatergories, paraIdAuthor };

            return DataProvider.Instance.ExcueNonQuery(query, sqlParameters);
        }

        public int Delete(string id)
        {
            string query = "delete Books where ID = @id ";

            SqlParameter paraId = new SqlParameter("@id", id);
            SqlParameter[] parameters = { paraId };

            return DataProvider.Instance.ExcueNonQuery(query, parameters);
        }
    }
}