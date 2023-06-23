using System;
namespace exercise                                                 
{                                                                  
  class ex4                                                    
   {    
     public static void ExecuteEx4()                                     
    {
     Console.WriteLine("В этом задании между числами должны быть равные промежутки");
     Console.WriteLine("Введите строку чисел через пробел и нажмите ввод");
     string line_raw = Console.ReadLine();
     string[] line_split = line_raw.Split(' ');
     Console.WriteLine(" ");
     for (int i = 0; i < line_split.Length; i++)
     {
     int x = -line_split[i].Length-2;
     Console.Write("{0,"+x+"}", line_split[i]);//попробовать стринг билдер
     }
     Console.ReadLine();
    }
   }
}
