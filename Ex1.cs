using System;
namespace exercise                                                 
{                                                                  
  class ex1                                                    
   {    
     public static void ExecuteEx1()                                         //функция по сравнению трех введеных чисел (возможно стоит сделать это через Math)
    {
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
          Console.WriteLine(num +" is Equal 0");                      //ничего интересного
         }
         Console.ReadLine();
    }
}
}
}