using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pssPss
{
    class Program
    {
        static void Main(string[] args)
        {
            int minimumPlayMilliseconds = 2000;
            int minimumPause = 5000;
            int maximumPlayMilliseconds = 4000;
            int maximumPause = 60000;
            //load mp3 from disk
            WMPLib.WindowsMediaPlayer pssPss = new WMPLib.WindowsMediaPlayer();
                (pssPss.settings as WMPLib.IWMPSettings).setMode("loop", true);
            string filePath = Path.GetFullPath("..\\..\\Data\\13 - Pss Pss.mp3");
            pssPss.URL = filePath;
            Random playTime = new Random();
            //set a random amount of time to play it (3-8 seconds)
            //play
            //set a random interval to have the program wait
            //pause
            while(true)
            {
                pssPss.controls.play();
                Double nextRandomNumber = playTime.NextDouble();
                Double adjustedRandomPlayTime = (nextRandomNumber) * (maximumPlayMilliseconds - minimumPlayMilliseconds);
                int sleepTime = (int)adjustedRandomPlayTime;
                int sleepAmount = sleepTime + (minimumPlayMilliseconds);
                System.Console.WriteLine(sleepAmount);
                Thread.Sleep(sleepAmount);
                pssPss.controls.pause();
                Thread.Sleep(sleepAmount);
            }
            //pssPss.controls.play();
            //System.Console.WriteLine("*elevator music simulator*");
            //System.Console.ReadKey();
            //pssPss.controls.pause();
            //System.Console.ReadKey();
            //pssPss.controls.play();
            //System.Console.ReadKey();
        }
        }
 }
