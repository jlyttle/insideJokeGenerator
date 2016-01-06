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
        public static int getRandomFromRange(int min, int max)
        {
            Double nextRandomNumber = playTime.NextDouble();
            Double adjustedRandomPlayTime = (nextRandomNumber) * (max - min);
            int sleepTime = (int)adjustedRandomPlayTime;
            int sleepAmount = sleepTime + (min);
            return sleepAmount;
        }

        static Random playTime;

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
            playTime = new Random();
            //set a random amount of time to play it (3-8 seconds)
            //play
            //set a random interval to have the program wait
            //pause
            while(true)
            {
                pssPss.controls.play();
                System.Console.WriteLine(getRandomFromRange(minimumPlayMilliseconds, maximumPlayMilliseconds));
                Thread.Sleep(getRandomFromRange(minimumPlayMilliseconds, maximumPlayMilliseconds));
                pssPss.controls.pause();
                Thread.Sleep(getRandomFromRange(minimumPlayMilliseconds, maximumPlayMilliseconds));
            }
        }
        }
 }
