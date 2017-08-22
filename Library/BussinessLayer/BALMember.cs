using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BussinessLayer
{
    public class BALMember
    {
        public DataTable GetMemberType()
        {
            string query = "select * from MemberTypes";
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
                throw;
            }
        }
        public DataTable GetGenderType()
        {
            string query = "select * from Gender";
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
                throw;
            }
        }
        public DataTable GetMemberStatus()
        {
            string query = "select * from MemberStatus";
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
                throw;
            }
        }
        public int CountMember()
        {
            string query = "select count(*) as memberNo from PersonalDetails";
            DataTable dt = new DataTable();
            dt = DAO.GetTable(query, null, CommandType.Text);
            try
            {
                if (dt != null)
                {
                    return Convert.ToInt32(dt.Rows[0]["memberNo"].ToString());
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        //public bool AddMember(int memberType,)
        //{
           

        //}
    }
}
