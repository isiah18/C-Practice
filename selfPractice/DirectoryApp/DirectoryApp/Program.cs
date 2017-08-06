using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //ShowWindowsDirectoryInfo();
            //DisplayImageFiles();
            //ModifyAppDirectory();
            //RemoveDirectories

            Console.ReadLine();
        }

        static void RemoveDirectories()
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(@".\MyFolder");
                dir.Delete(true);

                dir = new DirectoryInfo(@".\MyFolder2");
                dir.Delete(true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void ShowWindowsDirectoryInfo()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Windows");
            Console.WriteLine("Full Name : {0}", dir.FullName);
            Console.WriteLine("Name : {0}", dir.Name);
            Console.WriteLine("Parent : {0}", dir.Parent);
            Console.WriteLine("Creation Time : {0}", dir.CreationTime);
            Console.WriteLine("Attributes : {0}", dir.Attributes);
            Console.WriteLine("Root : {0}", dir.Root);
        }

        static void DisplayImageFiles()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Windows\Web\Wallpaper");
            FileInfo[] imageFiles = dir.GetFiles("*.jpg", SearchOption.AllDirectories);

            Console.WriteLine("Found {0} *.jpg files \n", imageFiles.Length);

            foreach (var image in imageFiles)
            {
                Console.WriteLine("File Name : {0}",image.Name);
                Console.WriteLine("Attributes : {0}",image.Attributes);
                Console.WriteLine("File Size : {0}",image.Length);
                Console.WriteLine("Creation Time : {0}",image.CreationTime);

            }

        }

        static void ModifyAppDirectory()
        {
            // . is a shortcut to say "start where i am or where my program is running
            DirectoryInfo dir = new DirectoryInfo(".");
            dir.CreateSubdirectory("MyFolder");
            Console.WriteLine(dir.FullName);

            DirectoryInfo myDataFolder = dir.CreateSubdirectory(@"MyFolder\Data");

            Console.WriteLine("Done");

        }
    }
}
