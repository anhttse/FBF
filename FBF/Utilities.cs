using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBF
{
    public static class Utilities
    {
        public static void WriteFriendIdToFile(string id,string path)
        {
            if (string.IsNullOrEmpty(path)) path = "friend_ids.txt";
            using (var wr = File.AppendText(path))
            {
                wr.Write(id+"|");
            }
        }
        public static void WriteErrorToLog(string msg)
        {
            using (var wr = File.AppendText("error_log.txt"))
            {
                wr.WriteLine($"==============={DateTime.Now}=================");
                wr.WriteLine(msg);
            }
        }
    }
}
