using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Managermentlibrary
{
    public partial class Register : Form
    {
        private string UserName;
        private string Password;
        private int Phone;
        private string BirthDay;
        private string Email;
        private string Name;
        private string idString;

        public Register()
        {
            InitializeComponent();
        }

        private void bConfirm_Click(object sender, EventArgs e)
        {
            DataTable dt = confirmUser();

            if (dt.Rows.Count > 0)
            {
                pPassword.Enabled = true;
            }
            else
            {
                MessageBox.Show("The username or phone number does not exist.", "Notification");
            }
        }

        private void bSubmit_Click(object sender, EventArgs e)
        {
            Password = txPasswordRegister.Text;
            string confirmPassword = txConfirmPasswordRegister.Text;

            if (confirmPassword == Password)
            {
                appreciate_value();
            }
            else
            {
                MessageBox.Show("Confirm password does not match.", "Notification");
            }
        }

        private void appreciate_value()
        {
            DataTable dt = confirmUser();
            foreach (DataRow row in dt.Rows)
            {
                idString = row["ID"].ToString() + ",";
                BirthDay = row["BirthDay"].ToString() + ",";
            }

            idString = idString.TrimEnd(',');
            BirthDay = BirthDay.TrimEnd(',');

            Email = txEmailRegister.Text;
            Name = txNameRegister.Text;
            int Id = int.Parse(idString);

            int update = IUD_DataUser.Instance.Update(Id,UserName,Name,BirthDay,Phone,Email,Password);
            if (update > 0)
            {
                MessageBox.Show("Successful", "Notification");
            }
            else
            {
                MessageBox.Show("false", "Notification");
            }
        }

        private DataTable confirmUser()
        {
            
            UserName = txUserNameRegister.Text;
            Phone = int.Parse(txPhoneRegister.Text);

            DataTable dt = LoadData.Instance.checkUser(UserName, Phone);
            return dt;
        }
    }
}
