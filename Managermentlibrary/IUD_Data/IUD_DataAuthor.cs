using Microsoft.Data.SqlClient;
using System.Data;

namespace Managermentlibrary.IUD_Data
{
    public class IUD_DataAuthor
    {
        private static IUD_DataAuthor instance;

        public static IUD_DataAuthor Instance
        {
            get { if (instance == null) instance = new IUD_DataAuthor(); return instance; }
            private set => instance = value;
        }

        private IUD_DataAuthor()
        { }

        public int Insert(string id, string name, string birthday, string Country)
        {
            string query = $"insert into dbo.Author values( @ID , @Name , @BirthDay , @Country )";

            SqlParameter paraID = new SqlParameter("@ID", id);
            SqlParameter paraName = new SqlParameter("@Name", name);
            SqlParameter paraBirthDay = new SqlParameter("@BirthDay", SqlDbType.Date);
            paraBirthDay.Value = birthday;
            SqlParameter paraCountry = new SqlParameter("@Country", Country);
            SqlParameter[] sqlParameters = { paraID, paraName, paraBirthDay, paraCountry };

            return DataProvider.Instance.ExcueNonQuery(query, sqlParameters);
        }

        public int Update(string id, string name, string birthday, string Country)
        {
            string query = $"update dbo.Author set Name = @Name , BirthDay = @Birthday ,Country = @Country where ID = @Id ";

            SqlParameter paraId = new SqlParameter("@Id", id);
            SqlParameter paraName = new SqlParameter("@Name", name);
            SqlParameter paraBirthDay = new SqlParameter("@BirthDay", SqlDbType.Date);
            paraBirthDay.Value = birthday;
            SqlParameter paraCountry = new SqlParameter("@Country", Country);
            SqlParameter[] sqlParameters = { paraId, paraName, paraBirthDay, paraCountry };

            return DataProvider.Instance.ExcueNonQuery(query, sqlParameters);
        }

        public int Delete(string id)
        {
            string query = "delete Author where ID = @id ";

            SqlParameter paraId = new SqlParameter("@id", id);
            SqlParameter[] parameters = { paraId };

            return DataProvider.Instance.ExcueNonQuery(query, parameters);
        }
    }
}