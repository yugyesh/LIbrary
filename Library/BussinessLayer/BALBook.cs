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
        //Retrive Book Classification to populate grid classification
        public DataTable GetClassification()
        {
            SqlParameter[] pram = new SqlParameter[]
            {
                new SqlParameter("@option",'A'),
            };
            DataTable dt = new DataTable();
            dt = DAO.GetTable("spGetClassification", pram, CommandType.StoredProcedure);
            return dt == null ? null : dt;
        }

        //Retrive Books Category ina specific classification
        public DataTable GetCategory(string classificationID)
        {
            SqlParameter[] pram = new SqlParameter[]
            {
                new SqlParameter("@option",'C'),
                new SqlParameter("@classificationID",classificationID),
            };
            DataTable dt = new DataTable();
            dt = DAO.GetTable("spGetClassification", pram, CommandType.StoredProcedure);
            return dt == null?null:dt;
        }

        //Retrive Books Subcategory based on CategoryID
        public DataTable GetSubCategory(string categoryID)
        {
            SqlParameter[] pram = new SqlParameter[]
            {
                new SqlParameter("@categoryID",categoryID),
            };
            DataTable dt = new DataTable();
            dt = DAO.GetTable("spGetClassification", pram, CommandType.StoredProcedure);
            return dt == null ? null : dt;
        }


        //Add Book Status
        public bool AddBStatus(string bStatusName, string userName)
        {
            SqlParameter[] pram = new SqlParameter[]
            {
                new SqlParameter("@bStatusName",bStatusName),
                new SqlParameter("@createdOn",DateTime.Today),
                new SqlParameter("@createdBy",userName),
            };
            string query = "Insert into BookStatus(BStatusName,CreatedOn,CreatedBy) values(@bStatusName,@createdOn,@createdBy)";
            return DAO.IUD(query, pram, CommandType.Text) > 0 ? true : false;
        }
        //Update Book Status
        public bool UpdateBStatus(string bStatusName, string userName, int bstatusID)
        {
            SqlParameter[] pram = new SqlParameter[]
            {
                new SqlParameter("@bStatusName",bStatusName),
                new SqlParameter("@modifiedOn",DateTime.Today),
                new SqlParameter("@modifiedBy",userName),
                new SqlParameter("@bstatusID",bstatusID),
            };
            string query = "Update BookStatus set BStatusName=@bStatusName,ModifiedOn=@modifiedOn,ModifiedBy=@modifiedBy where BStatusID=@bstatusID";
            return DAO.IUD(query, pram, CommandType.Text) > 0 ? true : false;
        }
        //Add Tag
        public bool AddTag(string tagName, string userName)
        {
            SqlParameter[] pram = new SqlParameter[]
            {
                new SqlParameter("@tagName",tagName),
                new SqlParameter("@createdOn",DateTime.Today),
                new SqlParameter("@createdBy",userName),
            };
            string query = "Insert into Tag(tagName,CreatedOn,CreatedBy) values(@tagName,@createdOn,@createdBy)";
            return DAO.IUD(query, pram, CommandType.Text) > 0 ? true : false;
        }
        //Update Tag
        public bool UpdateTag(string tagName, string userName, int tagID)
        {
            SqlParameter[] pram = new SqlParameter[]
            {
                new SqlParameter("@tagName",tagName),
                new SqlParameter("@modifiedOn",DateTime.Today),
                new SqlParameter("@modifiedBy",userName),
                new SqlParameter("@tagID",tagID),
            };
            string query = "Update Tag set TagName=@tagName,ModifiedOn=@modifiedOn,ModifiedBy=@modifiedBy where TagID=@tagID";
            return DAO.IUD(query, pram, CommandType.Text) > 0 ? true : false;
        }
        public DataTable GetBookStatus()
        {
            string query = "select BStatusID,BStatusName from BookStatus";
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
            string query = "select TagID,TagName from Tag";
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
        //Count book details to provide ID to new book detail added
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
                throw ex;
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
                new SqlParameter("@cost", Convert.ToDecimal(BookDetails[9])),
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
