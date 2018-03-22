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
    public class BALHelper
    {
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
                throw ex;
            }
        }
        //Retereiving CurrencyId from the currency code
        public string GetCurrencyID(string countryCode)
        {
            DataTable dt = new DataTable();
            SqlParameter[] pram = new SqlParameter[]
            {
                new SqlParameter("@currencyCode",countryCode)
            };
            dt = DAO.GetTable("select * from currency where CurrencyCode=@currencyCode", pram, CommandType.Text);
            //return dt == null || dt.Rows.Count == 0 ? 0 : dt.Rows[0]["CurrencyID"].ToString();
            return dt.Rows[0]["CurrencyID"].ToString() == null||dt.Rows[0]["CurrencyID"].ToString()==string.Empty? "0" : dt.Rows[0]["CurrencyID"].ToString();
        }

        public DataTable GetCurrencyType()
        {
            string query = "select * from Currency";
            //testing
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

        public DataTable GetUserRole()
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
        public DataTable GetAllDepartment()
        {
            string query = "select DepartmentID,DepartmentName from Department";
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
        public DataTable GetAllClass()
        {
            string query = "select ClassID,ClassName from Class";
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
        //Add Department
        public bool AddDepartment(string departmentName,string userName)
        {
            SqlParameter[] pram = new SqlParameter[]
            {
                new SqlParameter("@departmentName",departmentName),
                new SqlParameter("@createdOn",DateTime.Today),
                new SqlParameter("@createdBy",userName),
            };
            string query = "Insert into Department(DepartmentName,CreatedOn,CreatedBy) values(@DepartmentName,@createdOn,@createdBy)";
            return DAO.IUD(query, pram, CommandType.Text)>0?true:false;
        }
        //Update Department
        public bool UpdateDepartment(string departmentName, string userName,int departmentID)
        {
            SqlParameter[] pram = new SqlParameter[]
            {
                new SqlParameter("@departmentName",departmentName),
                new SqlParameter("@modifiedOn",DateTime.Today),
                new SqlParameter("@modifiedBy",userName),
                new SqlParameter("@departmentID",departmentID),
            };
            string query = "Update Department set DepartmentName=@departmentName,ModifiedOn=@modifiedOn,ModifiedBy=@modifiedBy Where DepartmentID=@departmentID";
            return DAO.IUD(query, pram, CommandType.Text) > 0 ? true : false;
        }
        //Add Class
        public bool AddClass(string className, string userName)
        {
            SqlParameter[] pram = new SqlParameter[]
            {
                new SqlParameter("@className",className),
                new SqlParameter("@createdOn",DateTime.Today),
                new SqlParameter("@createdBy",userName),
            };
            string query = "Insert into Class(ClassName,CreatedOn,CreatedBy) values(@className,@createdOn,@createdBy)";
            return DAO.IUD(query, pram, CommandType.Text) > 0 ? true : false;
        }
        //Update Class
        public bool UpdateClass(string className, string userName,int classID)
        {
            SqlParameter[] pram = new SqlParameter[]
            {
                new SqlParameter("@className",className),
                new SqlParameter("@modifiedOn",DateTime.Today),
                new SqlParameter("@modifiedBy",userName),
                new SqlParameter("@classID",classID),
            };
            string query = "Update Class set ClassName=@className,ModifiedOn=@modifiedOn,ModifiedBy=@modifiedBy where ClassID=@classID";
            return DAO.IUD(query, pram, CommandType.Text) > 0 ? true : false;
        }
    }
}
