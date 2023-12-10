using Managermentlibrary.IUD_Data;
using System.Data;

namespace Managermentlibrary
{
    public partial class Main : Form
    {
        //attriubte
        private string userName;
        private string password;
        private int IdUser;
        private int idOverDues;

        //contructor
        public Main()
        {
            InitializeComponent();
        }

        public Main(string UserName, string Password)
        {
            userName = UserName;
            password = Password;
            InitializeComponent();
        }

        #region event method
        //method borrowed
        private void bBorrowed_Click(object sender, EventArgs e)
        {
            string StartDate = dateTimeBorrow.Value.ToShortDateString();
            string EndDate = dateTimeDueBack.Value.ToShortDateString();
            int IdUser = int.Parse(txIDUser.Text);
            string IdBook = txIdBook.Text;

            int insert = IUD_DataBorrows.Instance.Insert(IdBook, StartDate, EndDate, IdUser);
            if (insert > 0)
            {
                MessageBox.Show("Successful", "Notification");
            }
            else
            {
                MessageBox.Show("false", "Notification");
            }
            loadForm();
        }

        //method reset
        private void bReset_Click(object sender, EventArgs e)
        {
            dateTimeDueBack.Text = "";
            dateTimeBorrow.Text = "";
            numUpDownQuantity.Value = 0;
        }

        //method return fine
        private void bReturnFine_Click(object sender, EventArgs e)
        {
            int delete = IUD_DataOverDues.Instance.Delete(idOverDues);

            if (delete > 0)
            {
                MessageBox.Show("Successful", "Notification");
            }
            else
            {
                MessageBox.Show("false", "Notification");
            }
            loadForm();
        }

        //method returned
        private void bReturned_Click(object sender, EventArgs e)
        {
            int idBorrow = int.Parse(txBorrowId.Text);
            int delete = IUD_DataBorrows.Instance.Delete(idBorrow);

            if (delete > 0)
            {
                MessageBox.Show("Successful", "Notification");
            }
            else
            {
                MessageBox.Show("false", "Notification");
            }
            loadForm();
        }

        //method find
        private void bFind_Click(object sender, EventArgs e)
        {
            string IdBook = txIdBook.Text;
            DataTable dt = LoadData.Instance.loadDataAllBook(IdBook);
            foreach (DataRow dr in dt.Rows)
            {
                txNameBook.Text = dr["NameBooks"].ToString();
                txAuthor.Text = dr["NameAuthor"].ToString();
                txCatergories.Text = dr["NameCatergories"].ToString();
            }
        }

        //method form load
        private void Main_Load(object sender, EventArgs e)
        {
            DataTable dt = LoadData.Instance.CheckDataUser(userName, password);
            foreach (DataRow dr in dt.Rows)
            {
                IdUser = Convert.ToInt32(dr["ID"].ToString());
                txNameUser.Text = dr["Name"].ToString();
                txUserName.Text = dr["UserName"].ToString();
                txPhone.Text = dr["Phone"].ToString();
                txEmail.Text = dr["Email"].ToString();
                dateTimeBirthDay.Text = dr["BirthDay"].ToString();
            }
            loadForm();
        }

        //method update
        private void bUpdateUser_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(txIDUser.Text);
            string Name = txNameUser.Text;
            string BirthDay = dateTimeBirthDay.Value.ToShortDateString();
            string Email = txEmail.Text;
            int Phone = int.Parse(txPhone.Text);

            int update = IUD_DataUser.Instance.Update(Id, userName, Name, BirthDay, Phone, Email, password);
            if (update > 0)
            {
                MessageBox.Show("Successful", "Notification");
            }
            else
            {
                MessageBox.Show("false", "Notification");
            }
            loadForm();
        }

        //method form closing
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the program?", "Notification", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        //CellContentClick DatagridView
        private void dgvListOfBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvListOfBooks.Rows[e.RowIndex];
            txIdBook.Text = row.Cells["dgvID"].Value.ToString();
            txNameBook.Text = row.Cells["dgvName"].Value.ToString();
            txCatergories.Text = row.Cells["dgvCatergories"].Value.ToString();
            txAuthor.Text = row.Cells["dgvAuthor"].Value.ToString();
        }

        private void dgvListBorrow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvListBorrow.Rows[e.RowIndex];
            txBorrowId.Text = row.Cells["IDListBorrow"].Value.ToString();
            dateTimeBorrow.Text = row.Cells["StartDateListBorrow"].Value.ToString();
            dateTimeDueBack.Text = row.Cells["EndDateListBorrow"].Value.ToString();
            txNameBook.Text = row.Cells["NameListBorrow"].Value.ToString();

            int borrowId = Convert.ToInt32(txBorrowId.Text);
            DataValidation.Instance.checkTimeBorrowLate(borrowId, dateTimeDueBack.Value);
            loadForm();
        }

        private void dgvListBorrowLate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvListBorrowLate.Rows[e.RowIndex];
            txBorrowId.Text = row.Cells["dgvIdBorrowLate"].Value.ToString();
            DateTimeReturn.Text = row.Cells["dgvDateLate"].Value.ToString();
            txReturnFine.Text = row.Cells["dgvFineLate"].Value.ToString();
            idOverDues = Convert.ToInt32(row.Cells["dgvIdOverDues"].Value.ToString());

            txTimeOverDue.Text = DataValidation.Instance.TimeOverDues(DateTimeReturn.Value);
        }
        #endregion

        // method LoadForm
        private void loadForm()
        {
            dgvListOfBooks.DataSource = LoadData.Instance.loadDataAllBook();
            txIDUser.Text = Convert.ToString(IdUser);
            dgvListBorrow.DataSource = LoadData.Instance.loadListBorrow(IdUser);
            dgvListBorrowLate.DataSource = LoadData.Instance.LoadOverDues(IdUser);
        }
    }
}