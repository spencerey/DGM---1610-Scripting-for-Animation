using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
     
      int myAge = 30;
      int nextYear = 31;
      
      double myGpa = 3.54;
      double expectedGpa = 3.8;
      
      //char myLetter = "D";
      //char myLastLetter = "R";
      
      string name = "David";
      string lastName = " Reyes";
      

      Console.WriteLine("Hello there, my name is "+ name + lastName);
      Console.WriteLine("I am " + myAge + " years old , and next year I will be "+ nextYear);
      Console.WriteLine("My current GPA is "+ myGpa + " and I expect to improve it and finish with a " + expectedGpa +" at the least") ;
      
      Console.WriteLine();
      Console.WriteLine("This are my examples of boolean :");
      Console.WriteLine();
      bool isAnimationFun = true;
      bool areTestsStressful = true;
      
      Console.WriteLine("Is animating fun?  " +isAnimationFun);
      Console.WriteLine("Taking tests can get stressful? " +areTestsStressful);
    }
  }
}
