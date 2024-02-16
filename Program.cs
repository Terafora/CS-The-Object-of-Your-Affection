using System;

namespace DatingProfile
{
  class Program
  {
    static void Main(string[] args)
    {
      Profile sam = new Profile("Sam Drakkila", 30, "New York", "USA", "he/him");
      
      sam.SetHobbies( new string[] {"listening to audiobooks and podcasts", "playing rec sports like bowling and kickball", "writing a speculative fiction novel", "reading advice columns"});

      Profile bob = new Profile("Bobbbbb", 15, "Wisconsin", "USA");

      bob.SetHobbies (new string[] {
        "playing video games"
      });

      Console.WriteLine(sam.ViewProfile());
      Console.WriteLine(bob.ViewProfile());
    }
  }
}
