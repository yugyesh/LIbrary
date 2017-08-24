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
    public class BALBook
    {
        public DataTable GetBookType()
        {
            string query = "select * from BookStatus";
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
        public bool CheckISBN(string isbnNumber)
        {
            SqlParameter[] pram = new SqlParameter[]
            {
                new SqlParameter("@isbn", isbnNumber)
            };
            string query = "select ISBN from Book where ISBN=@isbn";
            DataTable dt = new DataTable();
            dt = DAO.GetTable(query, pram, CommandType.Text);
            if (dt.Rows.Count>0)
            {
                return true;
            }
            return false;
        }


        public DataTable GetBookTag()
        {
            string query = "select * from Tag";
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
        public int CountBookDetails()
        {
            string query = "select count(*) as booksNo from BookDetails";
            DataTable dt = new DataTable();
            dt = DAO.GetTable(query, null, CommandType.Text);
            try
            {
                if (dt != null)
                {
                    return Convert.ToInt32(dt.Rows[0]["booksNo"].ToString());
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public bool AddBookDetails(List<string> BookDetails, byte photo = 0)
        {
            var pram = new List<SqlParameter>
            {
                new SqlParameter("@bookDetailID", BookDetails[0]),
                new SqlParameter("@bookTitle", BookDetails[1]),
                new SqlParameter("@place", BookDetails[2]),
                new SqlParameter("@publisherName", BookDetails[3]),
                new SqlParameter("@publishedYear", BookDetails[4]),
                new SqlParameter("@source", BookDetails[5]),
                new SqlParameter("@tagID",  Convert.ToInt32(BookDetails[6])),
                new SqlParameter("@author", BookDetails[7]),
                new SqlParameter("@pages", Convert.ToInt32(BookDetails[8])),
                new SqlParameter("@cost", Convert.ToInt32(BookDetails[9])),
                new SqlParameter("@bookCopies", Convert.ToInt32(BookDetails[10])),
                new SqlParameter("@classID",Convert.ToInt32(BookDetails[11])),
                new SqlParameter("@operation","S"),
            };
            return DAO.IUD("sp_SaveChangeBookInfo", pram, CommandType.StoredProcedure) >= 0 ?  true :  false;
        }
        public bool UpdateBookDetails(List<string> BookDetails, byte photo = 0)
        {
            var pram = new List<SqlParameter>
            {
                new SqlParameter("@bookDetailID", BookDetails[0]),
                new SqlParameter("@bookTitle", BookDetails[1]),
                new SqlParameter("@place", BookDetails[2]),
                new SqlParameter("@publisherName", BookDetails[3]),
                new SqlParameter("@publishedYear", BookDetails[4]),
                new SqlParameter("@source", BookDetails[5]),
                new SqlParameter("@tagID",  Convert.ToInt32(BookDetails[6])),
                new SqlParameter("@author", BookDetails[7]),
                new SqlParameter("@pages", Convert.ToInt32(BookDetails[8])),
                new SqlParameter("@cost", Convert.ToInt32(BookDetails[9])),
                new SqlParameter("@bookCopies", Convert.ToInt32(BookDetails[10])),
                new SqlParameter("@classID",Convert.ToInt32(BookDetails[11])),
                new SqlParameter("@operation","U"),
            };
            return DAO.IUD("sp_SaveChangeBookInfo", pram, CommandType.StoredProcedure) >= 0 ? true : false;
        }
        public bool AddBook(List<string> BookDetails, byte photo = 0)
        {
            var pram = new List<SqlParameter>
            {
                new SqlParameter("@ISBN", BookDetails[0]),
                new SqlParameter("@bStatusID", Convert.ToInt32(BookDetails[1])),
                 new SqlParameter("@bookDetailID", BookDetails[2]),
                new SqlParameter("@addedDate", Convert.ToDateTime(BookDetails[3])),
                new SqlParameter("@operation","S"),
            };
            return DAO.IUD("sp_SaveChangeBookInfo", pram, CommandType.StoredProcedure) >= 0 ? true : false;
        }
        public bool UpdateBook(List<string> BookDetails, byte photo = 0)
        {
            var pram = new List<SqlParameter>
            {
                new SqlParameter("@ISBN", BookDetails[0]),
                new SqlParameter("@bStatusID", Convert.ToInt32(BookDetails[1])),
                 new SqlParameter("@bookDetailID", BookDetails[2]),
                new SqlParameter("@addedDate", Convert.ToDateTime(BookDetails[3])),
                new SqlParameter("@operation","U"),
            };
            return DAO.IUD("sp_SaveChangeBookInfo", pram, CommandType.StoredProcedure) >= 0 ? true : false;
        }
        public DataTable GetBookInfo(string[] filters)
        {
            SqlParameter[] pram = new SqlParameter[]
            {
                new SqlParameter("@filterTitle","%"+filters[0]+"%"),
                new SqlParameter("@filterBookID", "%"+filters[1]+"%"),
                new SqlParameter("@filterClass", "%"+filters[2]+"%"),
            };
            return DAO.GetTable("sp_GetBookInfo", pram, CommandType.StoredProcedure);
        }
        public DataTable GetAllBookInfo(string[] filters)
        {
            SqlParameter[] pram = new SqlParameter[]
            {
                new SqlParameter("@filterTitle","%"+filters[0]+"%"),
                new SqlParameter("@filterBookID", "%"+filters[1]+"%"),
                new SqlParameter("@filterClass", "%"+filters[2]+"%"),
                new SqlParameter("@portion","A"),
            };
            return DAO.GetTable("sp_GetBookInfo", pram, CommandType.StoredProcedure);
        }
    }
}
