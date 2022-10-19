using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace fileRenamer3
{
    internal class Renamer
    {
        internal static bool rename(string dirPath, int startNumb, bool saveExtension)
        {
            string[] filesList = Directory.GetFiles(dirPath);

            for (int i = 0; i < filesList.Length; i++)
            {
                int sInd = filesList[i].LastIndexOf('\\');
                int dInd = filesList[i].LastIndexOf('.');
                string fileFormat = filesList[i].Substring(dInd);
                int fileNum = i + startNumb;

                string finalPath;
                if (saveExtension) { finalPath = filesList[i].Remove(sInd + 1) + fileNum + fileFormat; }
                else { finalPath = filesList[i].Remove(sInd + 1) + fileNum; }

                File.Move(filesList[i], finalPath);
            }

            return true;
        }
        internal static bool rename(string dirPath, string nameFormat, int startNumb, bool saveExtension)
        {
            string[] filesList = Directory.GetFiles(dirPath);

            for (int i = 0; i < filesList.Length; i++)
            {
                int sInd = filesList[i].LastIndexOf('\\');
                int dInd = filesList[i].LastIndexOf('.');
                string fileFormat = filesList[i].Substring(dInd);
                int fileNum = i + startNumb;

                string fileName = nameFormat.Replace("%NUM%", fileNum.ToString());
                
                string finalPath;
                if (saveExtension) { finalPath = filesList[i].Remove(sInd + 1) + fileName + fileFormat; }
                else { finalPath = filesList[i].Remove(sInd + 1) + fileName; }

                File.Move(filesList[i], finalPath);
            }

            return true;
        }
    }
}
