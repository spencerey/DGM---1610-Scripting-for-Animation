using System;

namespace MyApplic
{
  public class Conditional2
  {
    static void Main(string[] args)
    {
        int num = 1;
        int num2 = 3;

        if (num == 4)
        {
            Console.WriteLine("The correct number was 10 :) ");
        }
        else if (num == 2)
        {
            Console.WriteLine(" The correct number was 4 :) ");
        }
        else if(num2 == 3)
        {
            Console.WriteLine("The correct number was 5 :)");
        }
    }
   }
}