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
            Console.WriteLine("What is the smallest amount of time you want the song to play, in seconds?");
            int minimumPlayMilliseconds = Convert.ToInt32(Console.ReadLine()) * 1000;
            Console.WriteLine("What is the largest amount of time you want the song to play, in seconds?");
            int maximumPlayMilliseconds = Convert.ToInt32(Console.ReadLine()) * 1000;
            Console.WriteLine("What is the smallest amount of time you want the song to pause, in seconds?");
            int minimumPause = Convert.ToInt32(Console.ReadLine()) * 1000;
            Console.WriteLine("What is the largest amount of time you want the song to pause, in seconds?");
            int maximumPause = Convert.ToInt32(Console.ReadLine()) * 1000;
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
                Console.WriteLine(getRandomFromRange(minimumPlayMilliseconds, maximumPlayMilliseconds));
                Thread.Sleep(getRandomFromRange(minimumPlayMilliseconds, maximumPlayMilliseconds));
                pssPss.controls.pause();
                Thread.Sleep(getRandomFromRange(minimumPause, maximumPause));
            }
        }
        }
 }
