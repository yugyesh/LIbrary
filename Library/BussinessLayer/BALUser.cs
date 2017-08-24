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
            try
            {
                if (dt != null)
                {
                    return dt;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public DataTable CheckPassword()
         {
            string query = "select * from UserRole";
            DataTable dt = new DataTable();
            dt = DAO.GetTable(query, null, CommandType.Text);
            try
            {
                if (dt != null)
                {
                    return dt;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool CheckUser(string userName,string password,int roleID)
        {
            SqlParameter[] pram = new SqlParameter[]
            {
                new SqlParameter("@userName",userName),
                new SqlParameter("@password",password),
                new SqlParameter("@roleID",roleID)
            };
            string query = "select UserID,UserName from User where Password=@password,UserName=@userName,RoleID=@roleID";
            try
            {
                return DAO.IUD(query, pram, CommandType.Text) > 0 ? true : false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
