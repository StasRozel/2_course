using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace лаба__12
{
    static class RSADirInfo
    {
        public static void GetDirInfo(string pathToDir)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(pathToDir);

            string[] ParentDirectories = pathToDir.Split("\\");

            if (dirInfo.Exists) {
                Console.WriteLine($"Дата создания директории: {dirInfo.CreationTime}");
                Console.WriteLine($"Количество файлов в директории: {dirInfo.GetFiles().Length}");
                Console.WriteLine($"Количество поддиректориев в директории: {dirInfo.GetDirectories().Length}");

                Console.WriteLine("Родительские директории: ");
                for (int i = 0; i < ParentDirectories.Length - 1; i++)
                    Console.WriteLine(ParentDirectories[i]);
            }
        }
    }
}
