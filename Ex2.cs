using System;
namespace exercise                                                 
{                                                                  
  class ex2                                                    
   {    
     public static void ExecuteEx2()                                         //функция по сравнению трех введеных чисел (возможно стоит сделать это через Math)
    {
      Console.WriteLine("В этом задании нужно сравнить 3 числа");
      Console.WriteLine("Введите три числа через пробел");                           //общаемя с пользователем
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
     Console.ReadLine();
    }
}
}
