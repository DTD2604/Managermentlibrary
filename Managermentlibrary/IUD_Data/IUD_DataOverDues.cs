using Microsoft.Data.SqlClient;
using System.Data;

namespace Managermentlibrary.IUD_Data
{
    public class IUD_DataOverDues
    {
        private static IUD_DataOverDues instance;

        public static IUD_DataOverDues Instance
        {
            get { if (instance == null) instance = new IUD_DataOverDues(); return instance; }
            private set => instance = value;
        }

        private IUD_DataOverDues()
        { }

        public int Insert(int IdBorrow, string Date, int fine)
        {
            string query = $"insert into dbo.OverDues values( @IdBorrow , @Date , @Fine )";

            SqlParameter paraIdBorrow = new SqlParameter("@IdBorrow", IdBorrow);
            SqlParameter paraDate = new SqlParameter("@Date", SqlDbType.Date);
            paraDate.Value = Date;
            SqlParameter parafine = new SqlParameter("@Fine", fine);
            SqlParameter[] sqlParameters = { paraIdBorrow, paraDate, parafine };

            return DataProvider.Instance.ExcueNonQuery(query, sqlParameters);
        }

        public int Update(int ID, int IdBorrow, string Date, int fine)
        {
            string query = $"update dbo.OverDues set ID = @ID ,IdBorrow = @IdBorrow ,Date = @Date ,Fine = @Fine ";

            SqlParameter paraID = new SqlParameter("@ID", ID);
            SqlParameter paraIdBorrow = new SqlParameter("@IdBorrow", IdBorrow);
            SqlParameter paraDate = new SqlParameter("@Date", SqlDbType.Date);
            paraDate.Value = Date;
            SqlParameter parafine = new SqlParameter("@Fine", fine);
            SqlParameter[] sqlParameters = { paraID, paraIdBorrow, paraDate, parafine };

            return DataProvider.Instance.ExcueNonQuery(query, sqlParameters);
        }

        public int Delete(int id)
        {
            string query = "delete dbo.OverDues where ID = @id ";

            SqlParameter paraId = new SqlParameter("@id", id);
            SqlParameter[] parameters = { paraId };

            return DataProvider.Instance.ExcueNonQuery(query, parameters);
        }
    }
}