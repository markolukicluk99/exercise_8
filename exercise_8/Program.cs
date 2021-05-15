using System;
using System.IO;

namespace exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {

            // Get paths for both archives
            
            string path1 = System.IO.Path.GetFullPath(@"..\..\..\Archives\Archive1.txt");
            string path2 = System.IO.Path.GetFullPath(@"..\..\..\Archives\Archive2.txt");
            
            // IF THE PATHS CAUSE AN ERROR IN YOUR LOCAL DIRECTORY, YOU WILL HAVE TO HARDCODE THE PATH

            ArchivTeplot archiv = new ArchivTeplot();

            archiv.Load(path1);

            archiv.TiskTeplot();
            Console.WriteLine("");

            archiv.TiskPrumernychRocnichTeplot();
            Console.WriteLine("");

            archiv.TiskPrumernychMesicnichTeplot();
            Console.WriteLine("\n");

            archiv.Kalibrace(-0.1);
            archiv.TiskTeplot();
            Console.WriteLine("");

            archiv.Save(path2);
        }
    }
}
