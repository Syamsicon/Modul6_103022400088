// See https://aka.ms/new-console-template for more information
using Modul6_103022400088;

Console.WriteLine($"Review Lagu "   );
SayaMusicTrack track = new SayaMusicTrack("ERIKA");
track.increasePlayCount(1000);  

SayaMusicTrack track1 = new SayaMusicTrack("Heil Siege");
track1.increasePlayCount(500);

SayaMusicTrack track2 = new SayaMusicTrack("Adol hifter");
track2.increasePlayCount(75);

SayaMusicTrack track3 = new SayaMusicTrack("slip knot");
track3.increasePlayCount(150);

SayaMusicTrack track4 = new SayaMusicTrack("Sedia duit sebelum belanja");
track4.increasePlayCount(1500);

SayaMusicTrack track5 = new SayaMusicTrack("Let Down");
track5.increasePlayCount(1000);

SayaMusicTrack track6 = new SayaMusicTrack("1945");
track6.increasePlayCount(750);

SayaMusicTrack track7 = new SayaMusicTrack("L:agu1");
track6.increasePlayCount(3500);

SayaMusicTrack track8 = new SayaMusicTrack("Lagu2");
track6.increasePlayCount(5700);

SayaMusicTrack track9 = new SayaMusicTrack("Lagu 3");
track6.increasePlayCount(7500);

SayaMusicUser user = new SayaMusicUser("syamsi");
user.addTrack(track);
user.addTrack(track1);
user.addTrack(track2);
user.addTrack(track3);
user.addTrack(track4);
user.addTrack(track5);
user.addTrack(track6);
user.addTrack(track7);
user.addTrack(track8);
user.addTrack(track9);

user.printAllTrack();

Console.WriteLine();
Console.WriteLine("ini total playCount");
Console.WriteLine(user.getTotalPlayCount());

