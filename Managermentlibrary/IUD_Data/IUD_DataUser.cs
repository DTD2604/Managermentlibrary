using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managermentlibrary
{
    public class IUD_DataUser
    {
        private static IUD_DataUser instance;

        public static IUD_DataUser Instance
        {
            get { if (instance == null) instance = new IUD_DataUser(); return instance; }
            private set => instance = value;
        }
        private IUD_DataUser() { }

        public int Insert(string username, string name, string birthday, int phone, string email, string password)
        {
            string query = $"insert into dbo.Users values( @UserName , @Name , @BirthDay , @Phone , @Email , @Password )";
            SqlParameter paraUserName = new SqlParameter("@UserName", username);
            SqlParameter paraName = new SqlParameter("@Name", name);
            SqlParameter paraBirthDay = new SqlParameter("@BirthDay", SqlDbType.Date);
            paraBirthDay.Value = birthday;
            SqlParameter paraPhone = new SqlParameter("@Phone", phone);
            SqlParameter paraEmail = new SqlParameter("@Email", email);
            SqlParameter paraPassword = new SqlParameter("@Password", password);

            SqlParameter[] sqlParameters = { paraUserName, paraName, paraBirthDay, paraPhone, paraEmail, paraPassword };

            return DataProvider.Instance.ExcueNonQuery(query, sqlParameters);
        }

        public int Update(int id, string username, string name, string birthday, int phone, string email, string password)
        {
            string query = $"update dbo.Users set Username = @UserName , Name = @Name , BirthDay = @Birthday , Email = @Email , Phone = @Phone where ID = @Id ";

            SqlParameter paraId = new SqlParameter("@Id", id);
            SqlParameter paraUserName = new SqlParameter("@UserName", username);
            SqlParameter paraName = new SqlParameter("@Name", name);
            SqlParameter paraBirthDay = new SqlParameter("@BirthDay", SqlDbType.Date);
            paraBirthDay.Value = birthday;
            SqlParameter paraPhone = new SqlParameter("@Phone", phone);
            SqlParameter paraEmail = new SqlParameter("@Email", email);
            SqlParameter paraPassword = new SqlParameter("@Password", password);

            SqlParameter[] sqlParameters = { paraUserName, paraName, paraBirthDay, paraPhone, paraEmail, paraPassword, paraId };

            return DataProvider.Instance.ExcueNonQuery(query, sqlParameters);
        }

        public int Delete(int id)
        {
            string query = "delete Users where ID = @id ";
            SqlParameter paraId = new SqlParameter("@id", id);
            SqlParameter[] parameters = { paraId };

            return DataProvider.Instance.ExcueNonQuery(query, parameters);
        }
    }
}
