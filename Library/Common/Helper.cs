using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Helper
    {
        //send file path as parameter
        public static byte[] GetByte(string filePath)
        {
            //initialize a byte array with a null value initially
            byte[] picData = null;

            //use file info object to get file size
            FileInfo fInfo = new FileInfo(filePath);
            long numBytes = fInfo.Length;

            //Open file stream is used to read file
            FileStream fStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            //use binary reader to read file stream into byte array
            BinaryReader br = new BinaryReader(fStream);

            //when you use binary reader you need to supply number of bytes to read from file
            //in this case we are reading a whole file so need to supply tota no of bytes
            picData = br.ReadBytes((int)numBytes);
            return picData;
        }
        public static string GetMemberID(string fName, string LName,int number)
        {
            return fName.Substring(0, 2) + "-" + LName.Substring(0, 1) + "-" + number;
        }
        
    }
}
