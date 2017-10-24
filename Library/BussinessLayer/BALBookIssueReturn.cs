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
        public DataTable GetStudentInfo(string studentID, string studentName, string className)
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
        public DataTable GetTeacherInfo(string teacherID, string teacherName, string departmentID)
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
        public DataTable GetBookInfo(string ISBN)
        {
            SqlParameter[] pram = new SqlParameter[]
            {
                new SqlParameter("@ISBN",ISBN),
                new SqlParameter("@infoType","B"),
            };
            return DAO.GetTable("sp_GetInfoBurrower", pram, CommandType.StoredProcedure);
        }
        public bool CheckBookAvailibity(string ISBN)
        {
            SqlParameter[] pram = new SqlParameter[]
            {
                new SqlParameter("@ISBN",ISBN),
                new SqlParameter("@infoType","C"),
            };
            DataTable dt = new DataTable();
            dt = DAO.GetTable("sp_GetInfoBurrower", pram, CommandType.StoredProcedure);
            return dt.Rows.Count > 0 ? true : false;
        }
        public bool CheckBookIssued(string ISBN)
        {
            SqlParameter[] pram = new SqlParameter[]
            {
                new SqlParameter("@ISBN",ISBN),
            };
            string query = "Select BurrowerID from Burrower where BookID=@ISBN and Issued=1";
            DataTable dt = new DataTable();
            dt = DAO.GetTable(query, pram, CommandType.Text);
            return dt.Rows.Count > 0 ? true : false;
        }
        public bool IssueBook(string ISBN, string[] burrowerDetails)
        {
            SqlParameter[] pram = new SqlParameter[]
            {
                new SqlParameter("@ISBN",ISBN),
                new SqlParameter("@burrowerID",burrowerDetails[0]),
                new SqlParameter("@burrowedDate",Convert.ToDateTime(burrowerDetails[1])),
                new SqlParameter("@dueDate",Convert.ToDateTime(burrowerDetails[2])),
                new SqlParameter("@isStudent",Convert.ToBoolean(Convert.ToInt32(burrowerDetails[3]))),
                new SqlParameter("@issued",Convert.ToBoolean(Convert.ToInt32(burrowerDetails[4]))),
                new SqlParameter("@memberType",Convert.ToInt32(burrowerDetails[5])),
                new SqlParameter("@operation","I"),
            };
            DataTable dt = new DataTable();
            dt = DAO.GetTable("sp_BookIssueReturn", pram, CommandType.StoredProcedure);
            return dt.Rows.Count > 0 ? true : false;
        }
        public bool ReturnBook(string ISBN, string burrowerID)
        {
            SqlParameter[] pram = new SqlParameter[]
            {
                new SqlParameter("@ISBN",ISBN),
                new SqlParameter("@burrowerID",burrowerID),
                new SqlParameter("@returnedDate",DateTime.Today),
                new SqlParameter("@issued",Convert.ToBoolean(0)),
            };
            return DAO.IUD("sp_BookIssueReturn", pram, CommandType.StoredProcedure) > 0 ? true : false;
        }
        //check whether that user issued specific book during return
        public bool CheckUserIssued(string ISBN, string burrowerID)
        {
            SqlParameter[] pram = new SqlParameter[]
            {
                new SqlParameter("@ISBN",ISBN),
                new SqlParameter("@burrowerID",burrowerID),
            };
            DataTable dt = new DataTable();
            dt = DAO.GetTable("select * from burrower where bookid=@ISBN and burrowerID=@burrowerID", pram, CommandType.Text);
            return dt == null || dt.Rows.Count == 0 ? true : false;
        }
        //retriving information from the burrower using the isbn to find out the book burrower details
        public DataTable GetBurrowerDetails(string ISBN)
        {
            SqlParameter[] pram = new SqlParameter[]
            {
                new SqlParameter("@ISBN",ISBN),
                new SqlParameter("@infoType","BD"),
            };
            DataTable dt = new DataTable();
            dt = DAO.GetTable("sp_GetInfoBurrower", pram, CommandType.StoredProcedure);
            return dt == null || dt.Rows.Count == 0 ? null : dt;
        }
        public DataTable GetBurrowerName(string burrowerID,int burrowerType)
        {
            SqlParameter[] pram = new SqlParameter[]
            {
                new SqlParameter("@burrowerID",burrowerID),
                new SqlParameter("@burrowerType",burrowerType),
                new SqlParameter("@infoType","BN"),
            };
            DataTable dt = new DataTable();
            dt = DAO.GetTable("sp_GetInfoBurrower", pram, CommandType.StoredProcedure);
            return dt == null || dt.Rows.Count == 0 ? null : dt;
        }
    }
}
