using Managermentlibrary.IUD_Data;

namespace Managermentlibrary
{
    public partial class Admin : Form
    {
        //contructor
        public Admin()
        {
            InitializeComponent();
        }

        #region method event
        // Book
        private void bInsertBook_Click(object sender, EventArgs e)
        {
            string name = txNameBook.Text;
            string Id = txIDBook.Text;
            string IdAuthor = txIdAuthorBook.Text;
            string IdCatergories = txIdCatergoriesBook.Text;

            int insert = IUD_DataBook.Instance.Insert(Id, name, IdAuthor, IdCatergories);
            if (insert > 0)
            {
                MessageBox.Show("Successful", "Notification");
            }
            else
            {
                MessageBox.Show("false", "Notification");
            }
            loadform();

        }

        private void bUpdateBook_Click(object sender, EventArgs e)
        {
            string name = txNameBook.Text;
            string Id = txIDBook.Text;
            string IdAuthor = txIdAuthorBook.Text;
            string IdCatergories = txIdCatergoriesBook.Text;

            int update = IUD_DataBook.Instance.Update(Id, name, IdAuthor, IdCatergories);
            if (update > 0)
            {
                MessageBox.Show("Successful", "Notification");
            }
            else
            {
                MessageBox.Show("false", "Notification");
            }
            loadform();

        }

        private void bDeleteBook_Click(object sender, EventArgs e)
        {
            string Id = txIDBook.Text;

            int delete = IUD_DataBook.Instance.Delete(Id);
            if (delete > 0)
            {
                MessageBox.Show("Successful", "Notification");
            }
            else
            {
                MessageBox.Show("false", "Notification");
            }
            loadform();

        }

        //Author
        private void bInsertAuthor_Click(object sender, EventArgs e)
        {
            string Id = txIdAuthor.Text;
            string Name = txNameAuthor.Text;
            string Country = txCountryAuthor.Text;
            string BirthDay = dateTimeBirthDayAuthor.Value.ToShortDateString();

            int insert = IUD_DataAuthor.Instance.Insert(Id, Name, BirthDay, Country);
            if (insert > 0)
            {
                MessageBox.Show("Successful", "Notification");
            }
            else
            {
                MessageBox.Show("false", "Notification");
            }
            loadform();

        }

        private void bUpdateAuthor_Click(object sender, EventArgs e)
        {
            string Id = txIdAuthor.Text;
            string Name = txNameAuthor.Text;
            string Country = txCountryAuthor.Text;
            string BirthDay = dateTimeBirthDayAuthor.Value.ToShortDateString();

            int update = IUD_DataAuthor.Instance.Update(Id, Name, BirthDay, Country);
            if (update > 0)
            {
                MessageBox.Show("Successful", "Notification");
            }
            else
            {
                MessageBox.Show("false", "Notification");
            }
            loadform();

        }

        private void bDeleteAuthor_Click(object sender, EventArgs e)
        {
            string Id = txIdAuthor.Text;

            int delete = IUD_DataAuthor.Instance.Delete(Id);
            if (delete > 0)
            {
                MessageBox.Show("Successful", "Notification");
            }
            else
            {
                MessageBox.Show("false", "Notification");
            }
            loadform();

        }

        //Borrow
        private void bInsertBorrow_Click(object sender, EventArgs e)
        {
            string IdBook = txIdBookBorrow.Text;
            string StartDate = dateTimeStartDate.Value.ToShortDateString();
            string EndDate = dateTimeEndDate.Value.ToShortDateString();
            int IdUser = Convert.ToInt32(txIdUserBorrow.Text);

            int insert = IUD_DataBorrows.Instance.Insert(IdBook, StartDate, EndDate, IdUser);
            if (insert > 0)
            {
                MessageBox.Show("Successful", "Notification");
            }
            else
            {
                MessageBox.Show("false", "Notification");
            }
            loadform();

        }

        private void bUpdateBorrow_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(txIdBorrow.Text);
            string IdBook = txIdBookBorrow.Text;
            string StartDate = dateTimeStartDate.Value.ToShortDateString();
            string EndDate = dateTimeEndDate.Value.ToShortDateString();
            int IdUser = int.Parse(txIdUserBorrow.Text);

            int update = IUD_DataBorrows.Instance.Update(Id, IdBook, StartDate, EndDate, IdUser);
            if (update > 0)
            {
                MessageBox.Show("Successful", "Notification");
            }
            else
            {
                MessageBox.Show("false", "Notification");
            }
            loadform();

        }

        private void bDeleteBorrow_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(txIdBorrow.Text);

            int delete = IUD_DataBorrows.Instance.Delete(Id);
            if (delete > 0)
            {
                MessageBox.Show("Successful", "Notification");
            }
            else
            {
                MessageBox.Show("false", "Notification");
            }
            loadform();

        }

        //Due
        private void bInsertDue_Click(object sender, EventArgs e)
        {
            int IdBorrow = Convert.ToInt32(txIdBorrowDue.Text);
            string Date = dateTimeDateDue.Value.ToShortDateString();
            int Fine = int.Parse(txFineDue.Text);

            int insert = IUD_DataOverDues.Instance.Insert(IdBorrow, Date, Fine);
            if (insert > 0)
            {
                MessageBox.Show("Successful", "Notification");
            }
            else
            {
                MessageBox.Show("false", "Notification");
            }
            loadform();

        }

        private void bUpdateDue_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(txIdDue.Text);
            int IdBorrow = int.Parse(txIdBorrowDue.Text);
            string Date = dateTimeDateDue.Value.ToShortDateString();
            int Fine = int.Parse(txFineDue.Text);

            int update = IUD_DataOverDues.Instance.Update(Id, IdBorrow, Date, Fine);
            if (update > 0)
            {
                MessageBox.Show("Successful", "Notification");
            }
            else
            {
                MessageBox.Show("false", "Notification");
            }
            loadform();

        }

        private void bDeleteDue_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(txIdDue.Text);

            int delete = IUD_DataOverDues.Instance.Delete(Id);
            if (delete > 0)
            {
                MessageBox.Show("Successful", "Notification");
            }
            else
            {
                MessageBox.Show("false", "Notification");
            }
            loadform();

        }

        //Catergories
        private void bInsertCatergories_Click(object sender, EventArgs e)
        {
            string Id = txIdCatergories.Text;
            string Name = txNameCatergories.Text;
            string Description = txDescriptionCatergories.Text;

            int insert = IUD_DataCategories.Instance.Insert(Id, Name, Description);
            if (insert > 0)
            {
                MessageBox.Show("Successful", "Notification");
            }
            else
            {
                MessageBox.Show("false", "Notification");
            }
            loadform();

        }

        private void bUpdateCatergories_Click(object sender, EventArgs e)
        {
            string Id = txIdCatergories.Text;
            string Name = txNameCatergories.Text;
            string Description = txDescriptionCatergories.Text;

            int update = IUD_DataCategories.Instance.Update(Id, Name, Description);
            if (update > 0)
            {
                MessageBox.Show("Successful", "Notification");
            }
            else
            {
                MessageBox.Show("false", "Notification");
            }
            loadform();

        }

        private void bDeleteCatergories_Click(object sender, EventArgs e)
        {
            string Id = txIdCatergories.Text;

            int delete = IUD_DataCategories.Instance.Delete(Id);
            if (delete > 0)
            {
                MessageBox.Show("Successful", "Notification");
            }
            else
            {
                MessageBox.Show("false", "Notification");
            }
            loadform();

        }

        //User
        private void bInsertUser_Click(object sender, EventArgs e)
        {
            string UserName = txUsernameUser.Text;
            string Password = txPasswordUser.Text;
            string Name = txNameUser.Text;
            string BirthDay = dateTimeBirthDayUser.Value.ToShortDateString();
            string Email = txEmailUser.Text;
            int Phone = int.Parse(txPhoneUser.Text);

            int insert = IUD_DataUser.Instance.Insert(UserName, Name, BirthDay, Phone, Email, Password);
            if (insert > 0)
            {
                MessageBox.Show("Successful", "Notification");
            }
            else
            {
                MessageBox.Show("false", "Notification");
            }
            loadform();

        }

        private void bUpdateUser_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(txIdUser.Text);
            string UserName = txUsernameUser.Text;
            string Password = txPasswordUser.Text;
            string Name = txNameUser.Text;
            string BirthDay = dateTimeBirthDayUser.Value.ToShortDateString();
            string Email = txEmailUser.Text;
            int Phone = int.Parse(txPhoneUser.Text);

            int update = IUD_DataUser.Instance.Update(Id, UserName, Name, BirthDay, Phone, Email, Password);
            if (update > 0)
            {
                MessageBox.Show("Successful", "Notification");
            }
            else
            {
                MessageBox.Show("false", "Notification");
            }
            loadform();

        }

        private void bDeleteUser_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(txIdUser.Text);

            int delete = IUD_DataUser.Instance.Delete(Id);
            if (delete > 0)
            {
                MessageBox.Show("Successful", "Notification");
            }
            else
            {
                MessageBox.Show("false", "Notification");
            }
            loadform();

        }

        //Admin
        private void bInsertAdmin_Click(object sender, EventArgs e)
        {
            string UserName = txUserNameAdmin.Text;
            string Password = txPasswordAdmin.Text;
            string Name = txNameAdmin.Text;
            string BirthDay = dateTimeBirthDayAdmin.Value.ToShortDateString();
            string Email = txEmailAdmin.Text;
            int Phone = int.Parse(txPhoneAdmin.Text);

            int insert = IUD_DataAdmin.Instance.Insert(UserName, Name, BirthDay, Phone, Email, Password);
            if (insert > 0)
            {
                MessageBox.Show("Successful", "Notification");
            }
            else
            {
                MessageBox.Show("false", "Notification");
            }
            loadform();
        }

        private void bUpdateAdmin_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(txIdAdmin.Text);
            string UserName = txUserNameAdmin.Text;
            string Password = txPasswordAdmin.Text;
            string Name = txNameAdmin.Text;
            string BirthDay = dateTimeBirthDayAdmin.Value.ToShortDateString();
            string Email = txEmailAdmin.Text;
            int Phone = int.Parse(txPhoneAdmin.Text);

            int update = IUD_DataAdmin.Instance.Update(Id, UserName, Name, BirthDay, Phone, Email, Password);
            if (update > 0)
            {
                MessageBox.Show("Successful", "Notification");
            }
            else
            {
                MessageBox.Show("false", "Notification");
            }
            loadform();

        }

        private void bDeleteAdmin_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(txIdAdmin.Text);

            int delete = IUD_DataAdmin.Instance.Delete(Id);
            if (delete > 0)
            {
                MessageBox.Show("Successful", "Notification");
            }
            else
            {
                MessageBox.Show("false", "Notification");
            }
            loadform();

        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the program?", "announcement", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        //cellData
        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvBook.Rows[e.RowIndex];
            txIDBook.Text = row.Cells["clIdBook"].Value.ToString();
            txNameBook.Text = row.Cells["clNameBook"].Value.ToString();
            txIdCatergoriesBook.Text = row.Cells["clIdCatefgoriesBook"].Value.ToString();
            txIdAuthorBook.Text = row.Cells["clIdAuthorBook"].Value.ToString();
        }

        private void dgvAuthor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvAuthor.Rows[e.RowIndex];
            txIdAuthor.Text = row.Cells["clIdAuthor"].Value.ToString();
            txNameAuthor.Text = row.Cells["clNameAuthor"].Value.ToString();
            dateTimeBirthDayAuthor.Text = row.Cells["clBirthDayAuthor"].Value.ToString();
            txCountryAuthor.Text = row.Cells["clCountryAuthor"].Value.ToString();
        }

        private void dgvBorrow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvBorrow.Rows[e.RowIndex];
            txIdBorrow.Text = row.Cells["clIdBorrow"].Value.ToString();
            txIdBookBorrow.Text = row.Cells["clIdBookBorrow"].Value.ToString();
            dateTimeStartDate.Text = row.Cells["clStartDate"].Value.ToString();
            dateTimeEndDate.Text = row.Cells["clEndDate"].Value.ToString();
            txIdUserBorrow.Text = row.Cells["clIdUserBorrow"].Value.ToString();
        }

        private void dgvDue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvDue.Rows[e.RowIndex];
            txIdDue.Text = row.Cells["clIdDue"].Value.ToString();
            txIdBorrowDue.Text = row.Cells["clIdBorrowDue"].Value.ToString();
            dateTimeDateDue.Text = row.Cells["clDateDue"].Value.ToString();
            txFineDue.Text = row.Cells["clFineDue"].Value.ToString();
        }

        private void dgvCatergories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvCatergories.Rows[e.RowIndex];
            txIdCatergories.Text = row.Cells["clIdCatergories"].Value.ToString();
            txNameCatergories.Text = row.Cells["clNameCatergories"].Value.ToString();
            txDescriptionCatergories.Text = row.Cells["clDescriptionCatergories"].Value.ToString();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvUser.Rows[e.RowIndex];
            txIdUser.Text = row.Cells["clIdUser"].Value.ToString();
            txNameUser.Text = row.Cells["clNameUser"].Value.ToString();
            dateTimeBirthDayUser.Text = row.Cells["clBirthDayUser"].Value.ToString();
            txPhoneUser.Text = row.Cells["clPhoneUser"].Value.ToString();
            txEmailUser.Text = row.Cells["clEmailUser"].Value.ToString();
            txUsernameUser.Text = row.Cells["clUserNameUser"].Value.ToString();
            txPasswordUser.Text = row.Cells["clPasswrordUser"].Value.ToString();
        }

        private void dgvAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvAdmin.Rows[e.RowIndex];
            txIdAdmin.Text = row.Cells["clIdAdmin"].Value.ToString();
            txNameAdmin.Text = row.Cells["cINameAdmin"].Value.ToString();
            dateTimeBirthDayAdmin.Text = row.Cells["clBirthDayAdmin"].Value.ToString();
            txPhoneAdmin.Text = row.Cells["clPhoneAdmin"].Value.ToString();
            txEmailAdmin.Text = row.Cells["clEmailAdmin"].Value.ToString();
            txUserNameAdmin.Text = row.Cells["clUserNameAdmin"].Value.ToString();
            txPasswordAdmin.Text = row.Cells["clPasswordAdmin"].Value.ToString();
        }

        //load form
        private void Admin_Load(object sender, EventArgs e)
        {
            loadform();
        }
        #endregion

        private void loadform()
        {
            dgvAdmin.DataSource = LoadData.Instance.loadDataAdmin();
            dgvAuthor.DataSource = LoadData.Instance.loadDataAuthor();
            dgvBook.DataSource = LoadData.Instance.loadDataBooks();
            dgvBorrow.DataSource = LoadData.Instance.loadDataBorrowing();
            dgvCatergories.DataSource = LoadData.Instance.loadDataCatergories();
            dgvDue.DataSource = LoadData.Instance.loadDataOverDues();
            dgvUser.DataSource = LoadData.Instance.loadDataUser();
        }
    }
}