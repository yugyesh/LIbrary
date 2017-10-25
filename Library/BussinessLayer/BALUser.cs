using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;

namespace BussinessLayer
{
    public class BALUser
    {
        public DataTable GetUserType()
        {
            string query = "select * from UserRole";
            DataTable dt = new DataTable();
            dt = DAO.GetTable(query, null, CommandType.Text);
            return dt == null || dt.Rows.Count == 0 ? null : dt;
        }

        public bool CheckPassword(string userName)
        {
            SqlParameter[] pram = new SqlParameter[]
            {
                new SqlParameter("@userName", userName),
            };
            string query = "select userName from [User] where UserName=@userName";
            DataTable dt = new DataTable();
            dt = DAO.GetTable(query, pram, CommandType.Text);
            return dt == null || dt.Rows.Count > 0 ? true : false;
        }
        public bool ChangePassword(string userName, string password)
        {
            SqlParameter[] pram = new SqlParameter[]
                {
                    new SqlParameter("@userName", userName),
                    new SqlParameter("@password",password),
                };
            string query = "Update [User] set password=@password where userName=@userName";
            return DAO.IUD(query, pram, CommandType.Text) > 0 ? true : false;
        }

        public DataTable CheckUser(string userName, string password, int roleID)
        {
            SqlParameter[] pram = new SqlParameter[]
            {
                new SqlParameter("@userName",userName),
                new SqlParameter("@password",password),
                new SqlParameter("@roleID",roleID)
            };
            string query = "select UserID,UserName,roleID,PersonalDetailsID from [User] where [Password]=@password and UserName=@userName and RoleID=@roleID";
            DataTable dt = new DataTable();
            dt = DAO.GetTable(query, pram, CommandType.Text);
            return dt == null || dt.Rows.Count <= 0 ? null : dt;
        }
        //public bool CheckUser(int roleID)
        //{
        //    SqlParameter[] pram = new SqlParameter[]
        //    {
        //        new SqlParameter("@roleID",roleID),
        //    };
        //    string query = "select UserID,UserName from [User] where [Password]=@password and UserName=@userName and RoleID=@roleID";
        //    DataTable dt = new DataTable();
        //    dt = DAO.GetTable(query, pram, CommandType.Text);
        //    return dt == null || dt.Rows.Count > 0 ? true : false;
        //}
        public bool DeleteUser(string userID)
        {
            SqlParameter[] pram = new SqlParameter[]
                {
                    new SqlParameter("@userID", userID),
                };
            string query = "Delete from [User] where userID=@userID";
            return DAO.IUD(query, pram, CommandType.Text) > 0 ? true : false;
        }
        public bool UpdateUser(string userName, Int32 roleID, string userID)
        {
            SqlParameter[] pram = new SqlParameter[]
                {
                    new SqlParameter("@userName", userName),
                    new SqlParameter("@roleID",roleID),
                    new SqlParameter("@userID",userID),
                };
            string query = "Update [User] set userName=@userName,roleID=@roleID where userID=@userID";
            return DAO.IUD(query, pram, CommandType.Text) > 0 ? true : false;
        }
        public DataTable GetAllUser()
        {
            string query = @"select Username,UserID,[User].RoleID,UserRole.RoleName,Password,PersonalDetailsID from [User]
                             inner join UserRole on UserRole.RoleID=[User].RoleID";
            DataTable dt = new DataTable();
            dt = DAO.GetTable(query, null, CommandType.Text);
            return dt == null || dt.Rows.Count == 0 ? null : dt;
        }
        public DataTable GetAllUserFilter(string username)
        {
            SqlParameter[] pram = new SqlParameter[]
            {
                new SqlParameter("@userName","%"+username+"%"),
            };
            string query = @"select Username,UserID,[User].RoleID,UserRole.RoleName,Password,PersonalDetailsID from [User]
                             inner join UserRole on UserRole.RoleID=[User].RoleID where username like @userName";
            DataTable dt = new DataTable();
            dt = DAO.GetTable(query, pram, CommandType.Text);
            return dt == null || dt.Rows.Count == 0 ? null : dt;
        }
        public bool UpdateUserStatus(string userID,int statusID)
        {
            SqlParameter[] pram = new SqlParameter[]
            {
                new SqlParameter("@personalDetailID",userID),
                new SqlParameter("@statusID",statusID),
            };
            string query = "update PersonalDetails set StatusID=@statusID where PersonalDetailID=@personalDetailID";
            DataTable dt = new DataTable();
            return DAO.IUD(query, pram, CommandType.Text)>0?true:false;
        }
    }
}
