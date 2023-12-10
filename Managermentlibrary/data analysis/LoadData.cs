using Microsoft.Data.SqlClient;
using System.Data;

namespace Managermentlibrary
{
    public class LoadData
    {
        //contructor
        private LoadData()
        { }

        //singleton
        private static LoadData instance;

        public static LoadData Instance
        {
            get { if (instance == null) instance = new LoadData(); return instance; }
            private set => instance = value;
        }

        #region check form
        public DataTable CheckDataUser(string userName, string password)
        {
            DataTable dt = new DataTable();
            string query = "select * from Users where UserName = @username and Password = @password ";
            SqlParameter paraUserName = new SqlParameter("@username", userName);
            SqlParameter paraPassword = new SqlParameter("@password", password);

            SqlParameter[] sqlParameters = { paraUserName, paraPassword };

            dt = DataProvider.Instance.ExcuteQuery(query, sqlParameters);
            return dt;
        }

        public DataTable CheckDataAdmin(string userName, string password)
        {
            DataTable dt = new DataTable();
            string query = "select * from Admin where UserName = @username and Password = @password ";
            SqlParameter paraUserName = new SqlParameter("@username", userName);
            SqlParameter paraPassword = new SqlParameter("@password", password);

            SqlParameter[] sqlParameters = { paraUserName, paraPassword };

            dt = DataProvider.Instance.ExcuteQuery(query, sqlParameters);
            return dt;
        }

        public DataTable checkUser(string userName, int phone)
        {
            string query = "select * from Users where UserName = @UserName and Phone = @Phone ";
            SqlParameter paraUserName = new SqlParameter("@UserName", userName);
            SqlParameter paraPhone = new SqlParameter("@Phone", phone);
            SqlParameter[] parameter = { paraUserName, paraPhone };

            DataTable i = DataProvider.Instance.ExcuteQuery(query, parameter);
            return i;
        }
        #endregion

        #region load form
        public DataTable loadDataUser()
        {
            string query = "select * from Users";

            return DataProvider.Instance.ExcuteQuery(query);
        }

        public DataTable loadDataAdmin()
        {
            string query = "select * from Admin";

            return DataProvider.Instance.ExcuteQuery(query);
        }

        public DataTable loadDataBooks()
        {
            string query = "select * from Books";

            return DataProvider.Instance.ExcuteQuery(query);
        }

        public DataTable loadDataAuthor()
        {
            string query = "select * from Author";

            return DataProvider.Instance.ExcuteQuery(query);
        }

        public DataTable loadDataCatergories()
        {
            string query = "select * from Categories";

            return DataProvider.Instance.ExcuteQuery(query);
        }

        public DataTable loadDataOverDues()
        {
            string query = "select * from OverDues";

            return DataProvider.Instance.ExcuteQuery(query);
        }

        public DataTable loadDataBorrowing()
        {
            string query = "select * from Borrowing";

            return DataProvider.Instance.ExcuteQuery(query);
        }

        public DataTable loadDataAllBook(string IdBook = null)
        {
            string query = "";
            if (IdBook != null)
            {
                query = "select Books.Name as 'NameBooks',Author.Name as 'NameAuthor',Categories.Name as 'NameCatergories' from Books inner join Author on Books.IdAuthor = Author.ID inner join Categories on Books.IdCatergories = Categories.ID where Books.ID = @IdBooks  ";

                SqlParameter paraIdBooks = new SqlParameter("@IdBooks", IdBook);
                SqlParameter[] parameter = { paraIdBooks };

                return DataProvider.Instance.ExcuteQuery(query, parameter);
            }
            else
            {
                query = "select Books.ID, Books.Name as 'NameBooks',Author.Name as 'NameAuthor',Categories.Name as 'NameCatergories' from Books inner join Author on Books.IdAuthor = Author.ID inner join Categories on Books.IdCatergories = Categories.ID";

                return DataProvider.Instance.ExcuteQuery(query);
            }
        }

        public DataTable loadListBorrow(int IdUser)
        {
            string query = "select Borrowing.* ,Books.Name as NameBooks from Borrowing inner join Books on Borrowing.IdBook = Books.ID where borrowing.IdUser = @IdUser ";

            SqlParameter paraIdUser = new SqlParameter("@IdUser", IdUser);
            SqlParameter[] sqlParameters = { paraIdUser };

            return DataProvider.Instance.ExcuteQuery(query, sqlParameters);
        }

        public DataTable LoadOverDues(int IdUser)
        {
            string query = "select OverDues.* from OverDues inner join Borrowing on OverDues.IdBorrow = Borrowing.ID inner join Users on Borrowing.IdUser = Users.ID where Users.ID = @IdUser order by id desc ";

            SqlParameter paraIdUser = new SqlParameter("@IdUser", IdUser);
            SqlParameter[] parameters = { paraIdUser };

            return DataProvider.Instance.ExcuteQuery(query, parameters);
        }
        #endregion
    }
}