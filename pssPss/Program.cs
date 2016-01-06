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
            //load mp3 from disk
            WMPLib.WindowsMediaPlayer pssPss = new WMPLib.WindowsMediaPlayer();
                (pssPss.settings as WMPLib.IWMPSettings).setMode("loop", true);
            string filePath = Path.GetFullPath("..\\..\\Data\\13 - Pss Pss.mp3");
            pssPss.URL = filePath;
            //set a random amount of time to play it (3-8 seconds)
            //play
            //set a random interval to have the program wait
            //pause
            pssPss.controls.play();

            System.Console.WriteLine("*elevator music simulator*");
            System.Console.ReadKey();
            pssPss.controls.pause();
            System.Console.ReadKey();
            pssPss.controls.play();
            System.Console.ReadKey();
        }
        }
 }
