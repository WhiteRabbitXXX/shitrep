// See https://aka.ms/new-console-template for more information
using exercise;                                                      //сейчас не работает потому что не знаю upd: исправил 
using System;

namespace Main
{
  class MainProgr
  {
    static void Main()                                                //основное тело
    {
        try                                                           //не научился по человечески пользоваться исключениями поэтому сделал что сделал
        {
          int ch = 0;
          do
          {
            Console.Clear();
            Console.WriteLine("Chose Exercise");
            string chose = Console.ReadLine();
            if (chose == "exit")
             {
               ch = 0;
               Console.Clear();
             } 
            else
             {
               ch = Convert.ToInt32(chose);
               Console.Clear();
             }
            switch(ch)                                                    //выбираем кейс через переключатель
             {
              case 0:
              Console.WriteLine("Good Bye");
              break;
        
              case 1:
              ex1.ExecuteEx1();
              break;

              case 2:
              ex2.ExecuteEx2();
              break;
        
              case 3:                                                      
              ex3.ExecuteEx3();
              break;
             }                                                                        
           }
           while (ch > 0);
        }
        catch
        {
         Console.WriteLine("Oops");                                    //обработка исключения
        }
        finally
        {
         Console.ReadLine();
         Console.Clear();
        }
      }
   }
}
