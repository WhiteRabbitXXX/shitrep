// See https://aka.ms/new-console-template for more information
//using Testname; сейчас не работает потому что не знаю
using System;

namespace Test
{
  class TestProgramm
  {
    static void Comparasing()                                         //функция по сравнению трех введеных чисел (возможно стоит сделать это через Math)
    {
      Console.WriteLine("Enter three num");                           //общаемя с пользователем
      string numbers = Console.ReadLine();                            //получаем информатьён
      string[] nums = numbers.Split(' ');                             //переводим строку в текстовый массив
      if (nums.Length == 3)                                           //проверяем длину массива во избежание проблем (в конце концов сравниваем то три числа)
      {                                                               //в дальнейшем стоит доработать чтобы обрабатывалось любое кол-во чисел (пока висит)
       int[] gotnums = Array.ConvertAll(nums, int.Parse);             //переводим текст в цифорки
       if (gotnums[0] > gotnums[1] && gotnums[0] > gotnums[2])        //сравниваем
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
      else                                                            //если длина массива была больше трех скипаем сюда
      {
        Console.WriteLine("its not three");
      }
     
    }
    static void Calculate()                                          //функция сравнивает вводимое число с нулем
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
    }
    static void Main()                                                //основное тело
    {
        try                                                           //не научился по человечески пользоваться исключениями поэтому сделал что сделал
        {
        Console.WriteLine("Chose Exercise");
        int ch = Convert.ToInt32(Console.ReadLine());
        switch(ch)                                                    //выбираем кейс через переключатель
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
        Console.WriteLine("Oops");                                    //обработка исключения
        }
        finally
        {
         Console.ReadLine();
        }
    }
  }
}
