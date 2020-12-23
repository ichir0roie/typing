using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTyping.Code
{
    public class getQuesData
    {
        const string DataPath = "Data/";

        static public List<string[]> getTexts()
        {
            var fileDataList = new List<string[]>();
            var fileList = getFileNames();
            foreach(var file in fileList)
            {
                using(var reader=new StreamReader(file))
                {
                    var text = reader.ReadToEnd();
                    fileDataList.Add(getTextsBytext(text));
                }
            }

            return fileDataList;
        }

        static List<string> getFileNames()
        {
            var fileList = new List<string>();

            try
            {
                var array = System.IO.Directory.GetFiles(
                    DataPath, "*.txt", System.IO.SearchOption.AllDirectories);
                fileList = array.ToList<string>();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return fileList;
        }

        static string[] getTextsBytext(string text)
        {
            var list = text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None).ToList();
            var afterList = new List<string>();
            foreach(var i in list)
            {
                var tex = i.Trim();
                if (tex.Length > 0)
                {
                    afterList.Add(i.Trim());
                }
            }
            return afterList.ToArray();
        }

    }
}
