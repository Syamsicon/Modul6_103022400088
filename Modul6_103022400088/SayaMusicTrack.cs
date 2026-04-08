using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Modul6_103022400088
{
    public class SayaMusicTrack
    {
        private int id;
        public string title;
        private int playCount;

        public SayaMusicTrack(string title)
        {
            Random random = new Random();
            this.title = title;
            this.id = random.Next(10000, 99999);
            this.playCount = 0;
        }

        public void increasePlayCount(int count) 
        {
            playCount += count;
        }

        public int getPlayCount() 
        {
            return this.playCount;
        }

        public void printTrackDetails() 
        {
            Console.WriteLine("========== Track Details ==========");
            Console.WriteLine($"ID         : {id}");
            Console.WriteLine($"Title      : {title}");
            Console.WriteLine($"Play Count : {playCount}");
            Console.WriteLine("===================================");
        }
    }
}
