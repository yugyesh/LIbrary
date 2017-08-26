using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BussinessLayer
{
    public class BALBookIssueReturn
    {
        public DataTable GetStudentInfo(string studentID,string studentName,string className)
        {
            SqlParameter[] pram = new SqlParameter[]
            {
                new SqlParameter("@studentID","%"+studentID+"%"),
                new SqlParameter("@name","%"+studentName+"%"),
                new SqlParameter("@className","%"+className+"%"),
                new SqlParameter("@infoType","S")
            };
            return DAO.GetTable("sp_GetInfoBurrower", pram, CommandType.StoredProcedure);
        }
        public DataTable GetTeacherInfo(string teacherID,string teacherName,string departmentID)
        {
            SqlParameter[] pram = new SqlParameter[]
            {
                new SqlParameter("@teacherID","%"+teacherID+"%"),
                new SqlParameter("@name","%"+teacherName+"%"),
                new SqlParameter("@departmentName","%"+departmentID+"%"),
                new SqlParameter("@infoType","T"),
            };
            return DAO.GetTable("sp_GetInfoBurrower", pram, CommandType.StoredProcedure);
        }
        public DataTable CountIssuedBook()
        {
            return DAO.GetTable("sp_GetInfoBurrower", null, CommandType.StoredProcedure);
        }
    }
}
