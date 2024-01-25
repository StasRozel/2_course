using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба__12
{
    static class RSAFileInfo
    {
        public static void GetFileInfo(string pathToFile)
        {
            FileInfo fileInfo = new FileInfo(pathToFile);

            if (fileInfo.Exists) 
            { 
                Console.WriteLine($"Полный путь к файлу: {fileInfo.DirectoryName}\\{fileInfo.Name}");
                Console.WriteLine($"Название файла: {fileInfo.Name}");
                Console.WriteLine($"Размер файла: {fileInfo.Length}");
                Console.WriteLine($"Расширение файла: {fileInfo.Extension}");
                Console.WriteLine($"Дата создания файла: {fileInfo.CreationTime}");
                Console.WriteLine($"Последение изменение: {fileInfo.LastAccessTime}");
                Console.WriteLine();
            }
        }
    }
}
