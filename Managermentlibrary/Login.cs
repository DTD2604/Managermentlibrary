using System.Data;

namespace Managermentlibrary
{
    public partial class Login : Form
    {

        // attribute
        private string UserName;
        private string Password;
        private string Email;
        private int PhoneNumber;
        private string Name;
        private string BirthDay;

        //contructor
        public Login()
        {
            InitializeComponent();
        }

        #region method event 
        private void bSignIn_Click(object sender, EventArgs e)
        {
            UserName = txUserNameSignIn.Text;
            Password = txpasswordSignIn.Text;

            if (DataValidation.Instance.checkUser(UserName, Password) > 0)
            {
                if (DataValidation.Instance.checkUser(UserName, Password) == 1)
                {
                    Main main = new Main(UserName, Password);
                    this.Hide();
                    main.ShowDialog();
                    this.Show();
                }
                else
                {
                    Admin admin = new Admin();
                    this.Hide();
                    admin.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("UnsuccessFul", "notification");
            }
        }

        private void bSignUp_Click(object sender, EventArgs e)
        {
            UserName = txNameSignUp.Text;
            Password = txPasswordSignUp.Text;
            Email = txEmailSignUp.Text;
            PhoneNumber = int.Parse(txPhoneSignUp.Text);
            Name = txNameSignUp.Text;
            BirthDay = dateTimeBirthDay.Value.ToShortDateString();

            int insert = IUD_DataUser.Instance.Insert(UserName, Name, BirthDay, PhoneNumber, Email, Password);
            if (insert > 0)
            {
                MessageBox.Show("Successful", "Notification");
            }
            else
            {
                MessageBox.Show("false", "Notification");
            }
        }

        private void likRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog();
            this.Show();
        }
        #endregion

    }
}