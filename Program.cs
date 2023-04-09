// See https://aka.ms/new-console-template for more information
using Testname;
using System;

namespace Test
{
  class TestProgramm
  {
    static void Comparasing()
    {
      Console.WriteLine("Enter three num");
      string numbers = Console.ReadLine();
      string[] nums = numbers.Split(' ');
      if (nums.Length == 3)
      {
       int[] gotnums = Array.ConvertAll(nums, int.Parse);
       if (gotnums[0] > gotnums[1] && gotnums[0] > gotnums[2]) 
         {
           Console.WriteLine(gotnums[0]);
         }
       else if (gotnums[1] > gotnums[2])
         {
           Console.WriteLine(gotnums[1]);
         }
       else
         {
           Console.WriteLine(gotnums[2]);
         }
      }
      else
      {
        Console.WriteLine("its not three");
      }
     
    }
    static void Calculate()
    {
         Console.WriteLine("Enter Num");
         int num = Convert.ToInt32(Console.ReadLine());
         if (num > 0)
         {
          Console.WriteLine(num + " is High than 0");
         }
         else if (num < 0)
         {
          Console.WriteLine(num +" is Lower than 0");
         }
         else 
         {
          Console.WriteLine(num +" is Equal 0");
         }
    }
    static void Main()
    {
        try
        {
        Console.WriteLine("Chose Exercise");
        int ch = Convert.ToInt32(Console.ReadLine());
        switch(ch)
        {
        case 0:
        Calculate();
        break;

        case 1:
        Comparasing();
        break;
        
        case 2:
        Testname.Test.TestingName();
        break;
        }
        }
        catch
        {
        Console.WriteLine("Oops");
        }
        finally
        {
         Console.ReadLine();
        }
    }
  }
}