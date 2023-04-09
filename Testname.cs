using System;
namespace Testname
{
  class Test
   {
    static void TestingName()
      {
       Console.WriteLine("its alive");
       double b = Math.Exp(1);
       int x = 14;
       double n = Math.Pow(10,-x);
       double ans = Math.Truncate((Math.Round(b, x+1)/n))*n;
       Console.WriteLine(b);
       Console.WriteLine(ans);
      }
   }
}
