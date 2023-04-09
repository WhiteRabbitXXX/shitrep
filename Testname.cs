using System;
namespace Testname                                                 
{                                                                  
  class getTest                                                    
   {    
     //функция выводит число с точностью до х после запятой
    public static void TestingName()                                       
      {
       Console.WriteLine("Программа отсекает числа после запятой");                            
       Console.WriteLine("Введите число (дробь запишите через точку)"); 
      
      //присваиваем значение для округления
       double num = Convert.ToDouble(Console.ReadLine());
       Console.WriteLine("Количество знаков после запятой?");
      
      //задаем значение точности округления
       string cut = Console.ReadLine();
       int x = Convert.ToInt32(cut);
      
      //промежуточное значение 10^-x (строго говоря функция не округляет, а отсекает до запятой)
       double n = Math.Pow(10,-x);  
      
      //магия (округляю до х+1 знака после запятой, делю на 10^-х, выделяю целое-отсекаю грубо округленное,домножаю на 10^-х возвращая все на круги своя) вывожу полное число до отсечения
       double numround = Math.Truncate((Math.Round(num, x+1)/n))*n;       
       string ans = string.Format("{0:f"+cut+"}", numround);
      
      //результат отсечения
       Console.WriteLine(ans);                                     
      }
   }
}
