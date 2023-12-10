﻿using Microsoft.Data.SqlClient;
using System.Data;

namespace Managermentlibrary.IUD_Data
{
    public class IUD_DataAdmin
    {
        private static IUD_DataAdmin instance;

        public static IUD_DataAdmin Instance
        {
            get { if (instance == null) instance = new IUD_DataAdmin(); return instance; }
            private set => instance = value;
        }

        private IUD_DataAdmin()
        { }

        public int Insert(string username, string name, string birthday, int phone, string email, string password)
        {
            string query = $"insert into dbo.Admin values( @UserName , @Name , @BirthDay , @Phone , @Email , @Password )";
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
            string query = $"update dbo.Admin set Username = @UserName , Name = @Name , BirthDay = @Birthday , Email = @Email , Phone = @pPhone where ID = @Id ";

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
            string query = "delete Admin where ID = @id ";
            SqlParameter paraId = new SqlParameter("@id", id);
            SqlParameter[] parameters = { paraId };

            return DataProvider.Instance.ExcueNonQuery(query, parameters);
        }
    }
}