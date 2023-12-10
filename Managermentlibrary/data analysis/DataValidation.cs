using Managermentlibrary.IUD_Data;
using System.Data;

namespace Managermentlibrary
{
    public class DataValidation
    {
        private static DataValidation instance;

        public static DataValidation Instance
        {
            get { if (instance == null) instance = new DataValidation(); return instance; }
            private set => instance = value;
        }

        //Expired invoice time check method
        public void checkTimeBorrowLate(int IdBorrow, DateTime date)
        {
            int error = 0;
            if (date == DateTime.Today)
            {
                MessageBox.Show("It's the deadline.", "Notification");
            }
            else if (date < DateTime.Today)
            {
                int fine = 200;

                IUD_DataOverDues.Instance.Insert(IdBorrow, date.ToString(), fine);
                MessageBox.Show("It's overdue.", "Notification");
            }
        }

        public string TimeOverDues(DateTime dueBack)
        {
            TimeSpan timeSpan = DateTime.Today - dueBack;

            return timeSpan.Days.ToString();
        }

        //method check infor
        public int checkUser(string userName, string password)
        {
            DataTable dtUser = LoadData.Instance.CheckDataUser(userName, password);
            DataTable dtAdmin = LoadData.Instance.CheckDataAdmin(userName, password);

            if (dtUser.Rows.Count > 0)
            {
                return 1;
            }
            else if (dtAdmin.Rows.Count > 0)
            {
                return 2;
            }
            else
            {
                return -1;
            }
        }
    }
}