using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveInfoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] myDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in myDrives)
            {
                Console.WriteLine("Name : {0}", d.Name);
                Console.WriteLine("Type : {0}", d.DriveType);

                if (d.IsReady)
                {
                    Console.WriteLine("Free Space : {0}", d.TotalFreeSpace);
                    Console.WriteLine("Format : {0}", d.DriveFormat);
                    Console.WriteLine("Name : {0}", d.VolumeLabel);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
