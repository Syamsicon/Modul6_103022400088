using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Debug.Assert(title != null, "Title tidak boleh null");
            Debug.Assert(title.Length <= 200, "Title maks 200 karakter");

            Random random = new Random();
            this.title = title;
            this.id = random.Next(10000, 99999);
            this.playCount = 0;
        }

        public void increasePlayCount(int count) 
        {
            Debug.Assert(count <= 25_000_000, "maks input playcount 25.000.000");
            Debug.Assert(count >= 1, "input tidak bole negatif");
            try
            {
                playCount = checked(playCount + count);
            }
            catch (OverflowException ex) 
            {
                Console.WriteLine("[OVERFLOW ERROR] playcount melebihi batas input");
            }
            
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
