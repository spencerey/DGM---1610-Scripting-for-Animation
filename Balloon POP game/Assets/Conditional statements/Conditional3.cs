using System;

namespace MyApplication
{
  class ConditionalThree
  {
    static void Main(string[] args)
    {
      int age = 21;
      if (age >= 21) 
      {
        Console.WriteLine("You are old.");
      } 
      else 
      {
        Console.WriteLine("You are a baby.");
      }
    }
  }
}