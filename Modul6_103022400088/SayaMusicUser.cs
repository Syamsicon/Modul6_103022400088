using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Text;


namespace Modul6_103022400088
{ 
    public class SayaMusicUser
    {
        private int id;
        private string username;
        private List<SayaMusicTrack> uploadedTrack;

        public SayaMusicUser(string username) 
        {
            Debug.Assert(username != null, "Title tidak boleh null");
            Debug.Assert(username.Length <= 100, "Title maks 100 karakter");    

            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.uploadedTrack = new List<SayaMusicTrack>();
            this.username = username;
        }

        public int getTotalPlayCount()      
        {
            int totalPlayCount = 0;
            foreach (SayaMusicTrack track in uploadedTrack) 
            {
                totalPlayCount += track.getPlayCount();
            }
            return totalPlayCount;
        }

        public void addTrack(SayaMusicTrack track) 
        {
            Debug.Assert(track != null, "Track tidak boleh berisi null");

            uploadedTrack.Add(track);
        }

        public void printAllTrack() 
        {
            Console.WriteLine($"User: {username}");

            foreach (SayaMusicTrack track in uploadedTrack)
            {
                track.printTrackDetails();
            }
        }
    }
}
