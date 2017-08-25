using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data.SqlClient;

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
        public DataTable GetAllMember(int memberType)
        {
            string query = "sp_GetMemberDetails";
            SqlParameter[] pram = new SqlParameter[]{
                new SqlParameter("@memberType",memberType)
            };
            DataTable dt = new DataTable();
            dt = DAO.GetTable(query, pram, CommandType.StoredProcedure);
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
        public bool AddMember(int memberType, List<string> personalDetails, List<String> specificDetails, byte photo = 0 )
        {
            var pram = new List<SqlParameter>
            {
                new SqlParameter("@memberType", memberType),
                new SqlParameter("@firstName", personalDetails[0]),
                new SqlParameter("@middleName", personalDetails[1]),
                new SqlParameter("@lastName", personalDetails[2]),
                new SqlParameter("@genderID",Convert.ToInt32(personalDetails[3])),
                new SqlParameter("@statusID",Convert.ToInt32(personalDetails[4])),
                new SqlParameter("@address", personalDetails[5]),
                new SqlParameter("@phone", personalDetails[6]),
                new SqlParameter("@email", personalDetails[7]),
                new SqlParameter("@operationType","S"),
            };

            if (memberType == 1)
            {
                pram.Add(new SqlParameter("@studentID", specificDetails[0]));
                pram.Add(new SqlParameter("@majorSubject", specificDetails[1]));
                pram.Add(new SqlParameter("@classID", Convert.ToInt32(specificDetails[2])));
                return DAO.IUD("sp_SaveChangeMemberInfo", pram, CommandType.StoredProcedure) > 0 ? true : false;
            }
            else if (memberType == 2)
            {

                pram.Add(new SqlParameter("@teacherID", specificDetails[0]));
                pram.Add(new SqlParameter("@sectionName", specificDetails[1]));
                pram.Add(new SqlParameter("@departmentID", Convert.ToInt32(specificDetails[2])));
                return DAO.IUD("sp_SaveChangeMemberInfo", pram, CommandType.StoredProcedure) > 0 ? true : false;

            }
            else
            {
                pram.Add(new SqlParameter("@userID", specificDetails[0]));
                pram.Add(new SqlParameter("@userName", specificDetails[1]));
                pram.Add(new SqlParameter("@password", specificDetails[2]));
                pram.Add(new SqlParameter("@roleID", Convert.ToInt32(specificDetails[3])));
                return DAO.IUD("sp_SaveChangeMemberInfo", pram, CommandType.StoredProcedure) > 0 ? true : false;
            }
        }
        public bool UpdateMember(int memberType, List<string> personalDetails, List<String> specificDetails, byte photo = 0)
        {
            var pram = new List<SqlParameter>
            {
                new SqlParameter("@memberType", memberType),
                new SqlParameter("@firstName", personalDetails[0]),
                new SqlParameter("@middleName", personalDetails[1]),
                new SqlParameter("@lastName", personalDetails[2]),
                new SqlParameter("@genderID",Convert.ToInt32(personalDetails[3])),
                new SqlParameter("@statusID",Convert.ToInt32(personalDetails[4])),
                new SqlParameter("@address", personalDetails[5]),
                new SqlParameter("@phone", personalDetails[6]),
                new SqlParameter("@email", personalDetails[7]),
                new SqlParameter("@operationType","U"),
                new SqlParameter("@personalDetailID",personalDetails[8]),
                new SqlParameter("@contactID",personalDetails[9]),
            };

            if (memberType == 1)
            {
                pram.Add(new SqlParameter("@teacherID", specificDetails[0]));
                pram.Add(new SqlParameter("@sectionName", specificDetails[1]));
                pram.Add(new SqlParameter("@classID", Convert.ToInt32(specificDetails[2])));
                return DAO.IUD("sp_SaveChangeMemberInfo", pram, CommandType.StoredProcedure) > 0 ? true : false;
            }
            else if (memberType == 2)
            {
                pram.Add(new SqlParameter("@studentID", specificDetails[0]));
                pram.Add(new SqlParameter("@majorSubject", specificDetails[1]));
                pram.Add(new SqlParameter("@departmentID", Convert.ToInt32(specificDetails[2])));
                return DAO.IUD("sp_SaveChangeMemberInfo", pram, CommandType.StoredProcedure) > 0 ? true : false;
            }
            else
            {
                pram.Add(new SqlParameter("@userID", specificDetails[0]));
                pram.Add(new SqlParameter("@userName", specificDetails[1]));
                pram.Add(new SqlParameter("@password", specificDetails[2]));
                pram.Add(new SqlParameter("@roleID", Convert.ToInt32(specificDetails[3])));
                return DAO.IUD("sp_SaveChangeMemberInfo", pram, CommandType.StoredProcedure) > 0 ? true : false;
            }
        }
    }
}
