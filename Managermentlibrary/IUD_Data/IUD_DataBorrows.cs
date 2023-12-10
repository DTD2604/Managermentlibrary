using Microsoft.Data.SqlClient;
using System.Data;

namespace Managermentlibrary.IUD_Data
{
    public class IUD_DataBorrows
    {
        private static IUD_DataBorrows instance;

        public static IUD_DataBorrows Instance
        {
            get { if (instance == null) instance = new IUD_DataBorrows(); return instance; }
            private set => instance = value;
        }

        private IUD_DataBorrows()
        { }

        public int Insert(string IdBook, string StartDate, string EndDate, int IdUser)
        {
            string query = $"insert into dbo.Borrowing values( @IdBook , @StartDate , @EndDate , @IdUser )";

            SqlParameter paraIdBook = new SqlParameter("@IdBook", IdBook);
            SqlParameter paraStartDate = new SqlParameter("@StartDate", SqlDbType.Date);
            paraStartDate.Value = StartDate;
            SqlParameter paraEndDate = new SqlParameter("@EndDate", SqlDbType.Date);
            paraEndDate.Value = EndDate;
            SqlParameter paraIdUser = new SqlParameter("@IdUser", IdUser);
            SqlParameter[] sqlParameters = { paraIdBook, paraStartDate, paraEndDate, paraIdUser };

            return DataProvider.Instance.ExcueNonQuery(query, sqlParameters);
        }

        public int Update(int ID, string IdBook, string StartDate, string EndDate, int IdUser)
        {
            string query = $"update dbo.Borrowing set ID = @ID ,IdBook = @IdBook ,StartDate = @StartDate ,EndDate = @EndDate ,IdUser = @IdUser ";

            SqlParameter paraID = new SqlParameter("@ID", ID);
            SqlParameter paraIdBook = new SqlParameter("@IdBook", IdBook);
            SqlParameter paraStartDate = new SqlParameter("@StartDate", SqlDbType.Date);
            paraStartDate.Value = StartDate;
            SqlParameter paraEndDate = new SqlParameter("@EndDate", SqlDbType.Date);
            paraEndDate.Value = EndDate;
            SqlParameter paraIdUser = new SqlParameter("@IdUser", IdUser);
            SqlParameter[] sqlParameters = { paraID, paraIdBook, paraStartDate, paraEndDate, paraIdUser };

            return DataProvider.Instance.ExcueNonQuery(query, sqlParameters);
        }

        public int Delete(int id)
        {
            string query = "delete dbo.Borrowing where ID = @id ";

            SqlParameter paraId = new SqlParameter("@id", id);
            SqlParameter[] parameters = { paraId };

            return DataProvider.Instance.ExcueNonQuery(query, parameters);
        }
    }
}