using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Helper
{
    public class FileHelper
    {
        public static byte[] ReadFile(string sPath)
        {
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;

            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

            BinaryReader bReader = new BinaryReader(fStream);

            byte[] data = bReader.ReadBytes((int)numBytes);

            return data;
        }
    }
}
