﻿using Shopping.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.BusinessLayer
{
    public class Users
    {
        DbContext context;

        public Users(string connectionString) {
          context = new DbContext(connectionString);
        }
        public bool authenticateUser(string userName, string password)
        {
            string query = $"select [Username],[Password] from Users where Password='{password}' and Username='{userName}'and Role='User'";
            DataTable dataTable = context.ExecuteQuery(query);


            return dataTable.Rows.Count > 0;
        }
        public int UpdateUserPassword(int id, string userName, string password)
        {
            string query = $"UPDATE Users SET UserName = '{userName}', Password = '{password}' WHERE UserID = {id}";
            int rowAffected = context.ExecuteNonQuery(query);
            return rowAffected;
        }
        public DataTable getAllUsers()
        {
            string query = "Select UserId,Username,Password,Email,Age,Address,Role from Users";
            DataTable dt=context.ExecuteQuery(query);

            return dt;
        }
        public DataTable Login(string username,string password,string role)
        {
            string query= $"SELECT * FROM Users WHERE Username='{username}' AND Password='{password}'AND Role='{role}'";
            DataTable dt = context.ExecuteQuery(query);
            return dt;
            
            
        }
        public int LoginAsUser(string username, string password)
        {
            string query = $"SELECT * FROM Users WHERE Username='{username}' AND Password='{password}'AND Role='User'";
            DataTable dt = context.ExecuteQuery(query);
            return dt.Rows.Count;


        }
        public int LoginAsAdmin(string username, string password)
        {
            string query = $"SELECT * FROM Users WHERE Username='{username}' AND Password='{password}'AND Role='Admin'";
            DataTable dt = context.ExecuteQuery(query);
            return dt.Rows.Count    ;


        }
        public bool authenticateAdmin(string username, string password)
        {
            string query = $"SELECT * FROM Users WHERE Username='{username}' AND Password='{password}'AND Role='Admin'";
            DataTable dt = context.ExecuteQuery(query);
            return dt.Rows.Count>0;


        }

        public int AddUser(string u_name,string u_pass,string u_Email,int u_age,string u_address,string u_role)
        {
            String query = $"Insert into Users (Username,Password,Email,Age,Address,Role) values ('{u_name}','{u_pass}','{u_Email}','{u_age}','{u_address}','{u_role}')";
            int rowsAffected = context.ExecuteNonQuery(query);
            return rowsAffected;

        }

        public int UpdateUser(string u_name, string u_pass, string u_Email, int u_age, string u_address, string u_role,int id)
        {
            String query = $"Update Users set Username='{u_name}',Password='{u_pass}',Email='{u_Email}',Age='{u_age}',Address='{u_address}',Role='{u_role}' where UserId='{id}' ";
            int rowsAffected = context.ExecuteNonQuery(query);
            return rowsAffected;
        }

        public int DeleteUser(int id)
        {
            String query = $"Delete from Users where UserId='{id}'";
            int rowsAffected = context.ExecuteNonQuery(query);
            return rowsAffected;
        }

        public int UpdatePassword(int id,string username,string u_pass)
        {
            String query = $"Update Users set UserName = '{username}',Password='{u_pass}' where UserId='{id}'";
            int rowsAffected = context.ExecuteNonQuery(query);
            return rowsAffected;
        }

        public DataTable authenticateUserData(string userName, string password)
        {
            string query = $"select [UserId],[Username],[Password],[Email],[Age],[Address],[Role] from Users where  Username='{userName}'and Role='User'";
            DataTable dataTable = context.ExecuteQuery(query);


            return dataTable;
        }

        public DataTable authenticateAdminData(string userName, string password)
        {
            string query = $"select [UserId], [Username],[Password] from Users where Password='{password}' and Username='{userName}'and Role='Admin'";
            DataTable dataTable = context.ExecuteQuery(query);


            return dataTable;
        }

     
    }
}
