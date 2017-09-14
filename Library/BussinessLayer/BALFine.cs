using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;

namespace BussinessLayer
{
   public class BALFine
    {
        public DataTable GetFineDetails(string studentName)
        {
            SqlParameter[] pram = new SqlParameter[]
            {
                new SqlParameter("@today",DateTime.Today),
                new SqlParameter("@name","%"+studentName+"%"),
            };
            DataTable dt = new DataTable();
            dt = DAO.GetTable("sp_GetFineInfo", pram, CommandType.StoredProcedure);
            return dt == null ? null : dt;
        }
        //Checking Fine Amount
        //public DataTable FineAmount(string burrowerID)
        //{
        //    SqlParameter[] pram = new SqlParameter[]
        //    {
        //        new SqlParameter("@burrowerID",burrowerID),
        //    };
            
        //}
        public bool AddFineAmount(int fineAmount,string burrowerID,string ISBN)
        {
            SqlParameter[] pram = new SqlParameter[]
            {
                new SqlParameter("@paidDate",DateTime.Today),
                new SqlParameter("@burrowerID",burrowerID),
                new SqlParameter("@ISBN",ISBN),
                new SqlParameter("@fineAmount",fineAmount),
            };
            return DAO.IUD("sp_AddFine", pram, CommandType.StoredProcedure) > 0?true:false;
        }
    }
}
