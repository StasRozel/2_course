using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace лаба__12
{
    class RSAFileManager
    {

        static public void GetDiskInfo(string driveName)
        {
            DirectoryInfo drive = new DirectoryInfo(driveName);
            FileInfo[] files = drive.GetFiles();
            DirectoryInfo[] folders = drive.GetDirectories();

            Directory.CreateDirectory(Path.Combine(driveName, "RSAInspect"));

            string filePath = Path.Combine(driveName, "RSAInspect", "rsadirinfo.txt");
            using (StreamWriter writer = File.CreateText(filePath))
            {
                foreach (DirectoryInfo d in folders)
                {
                    writer.WriteLine(d.Name);
                }

                foreach (FileInfo f in files)
                {
                    writer.WriteLine(f.Name);
                }
            }

            string copyPath = Path.Combine(driveName, "RSAInspect", "rsadirinfo_copy.txt");
            File.Copy(filePath, copyPath);

            File.Delete(filePath);
        }
        
        static public void CreateNewFolder(string driveName, string copyDir, string extension)
        {
            Directory.CreateDirectory(Path.Combine(driveName, "RSAFiles"));

            DirectoryInfo dir = new DirectoryInfo(Path.Combine(copyDir));

            FileInfo[] files = dir.GetFiles();

            foreach (var item in files)
            {
                if (item.Extension == extension)
                {
                    File.Copy(item.FullName, Path.Combine(driveName, "RSAFiles", $"{item.Name}_copy.pptx"));
                }
            }

            Directory.Move(Path.Combine(driveName, "RSAFiles"), Path.Combine(driveName, "RSAInspect", "RSAFiles"));
        }

        static public void CreateArchive()
        {

        }

    }
}
