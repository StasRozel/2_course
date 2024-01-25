using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace лаба__12
{
    static class RSADiskInfo
    {
        public static void GetDiskInfo()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Название: {drive.Name}");
                Console.WriteLine($"Тип: {drive.DriveType}");
                if (drive.IsReady)
                {
                    Console.WriteLine($"Объем диска: {Math.Floor(drive.TotalSize / (Math.Pow(1024, 3)))} Гб");
                    Console.WriteLine($"Свободное пространство: {Math.Floor(drive.TotalFreeSpace / (Math.Pow(1024, 3)))} Гб");
                    Console.WriteLine($"Метка диска: {drive.VolumeLabel}");
                }
                Console.WriteLine();
            }
        }
    }
}
