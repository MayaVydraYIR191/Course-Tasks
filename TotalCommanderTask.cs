using System;
using System.IO;

namespace ConsoleApp70
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"c:\test\file.txt";
            string directory = @"c:\test\directory.txt";
            string copyfile = @"c:\test\copyfile.txt";
            string renamefile = @"c:\test\renamefile.txt";
            string replace = @"c:\test\replace.txt";

            TotalCommander.FileCreating(file);
            TotalCommander.FileCreating(copyfile);
            TotalCommander.FileCreating(renamefile);
            TotalCommander.FileCreating(replace);
            TotalCommander.DireCreating(directory);
            TotalCommander.Copying(file, copyfile);
            TotalCommander.Renaming(file, renamefile, replace);
            TotalCommander.DireDestroying(directory);
            TotalCommander.FileDestroying(file);

        }
    }

    public class TotalCommander
    {
        public static void FileCreating(string file)
        {
            if(!File.Exists(file))
            {
                File.Create(file);
            }
        }

        public static void FileDestroying(string file)
        {
            if(File.Exists(file))
            {
                File.Delete(file);
            }
        }
        public static void DireCreating(string directory)
        {
            Directory.CreateDirectory(directory);
        }

        public static void DireDestroying(string directory)
        {
            Directory.Delete(directory);
        }

        public static void Copying(string file, string copyfile)
        {
            if(File.Exists(file))
            {
                File.Copy(file,copyfile,true);
            }
        }
        public static void Renaming(string file, string renamefile,string replace)
        {
            if(File.Exists(file))
            {
                File.Replace(file,renamefile,replace);
            }
        }
    }

}
