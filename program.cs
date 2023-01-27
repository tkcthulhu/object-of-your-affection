using System;

namespace DatingProfile
{
  class Program
  {
    static void Main(string[] args)
    {
      Profile Sam = new Profile("Sam", "Arnold", 29, "Lexington", "KY", "USA", "he/him");

      Sam.SetHobbies(new string[] {"Audiobooks and podcasts", "Dungeons and Dragons", "Olympic Weightlifting"});

      Console.WriteLine(Sam.ViewProfile());
    }
  }
}
