using System;

namespace MyApplication
{
  class ConditionalFour
  {
    static void Main(string[] args)
    {
      int time = 12;
      if (time == 12) 
      {
        Console.WriteLine("It is noon.");
      } 
      else 
      {
        Console.WriteLine("It might be early in the day or late at night.");
      }
    }
  }
}