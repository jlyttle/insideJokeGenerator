using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pssPss
{
    class Program
    {
        static void Main(string[] args)
        {
            WMPLib.WindowsMediaPlayer pssPss = new WMPLib.WindowsMediaPlayer();
            string filePath = Path.GetFullPath("..\\..\\Data\\13 - Pss Pss.mp3");
            pssPss.URL = filePath;
            pssPss.controls.play();

            System.Console.WriteLine("*elevator music simulator*");
            System.Console.ReadKey();
        }
        }
 }
