using System;

namespace MyApplication
{
  class ConditionalFive
  {
    static void Main(string[] args)
    {
      int age = 19;
      if (age <= 14) 
      {
        Console.WriteLine("You should not be even thinking of drinking");
      } 
      else if(age <= 20) 
      {
        Console.WriteLine("You still cannot drink");
      }
      else
      {
        Console.WriteLine("You are allowed to drink");
      }
    }
  }
}
