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
                throw;
                return null;
            }
            
        }
    }
}
