using System;
namespace DateTimeEmCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var data = DateTime.Now; //pega  a data de hoje
            var data = new DateTime(2020, 10, 12, 8, 23, 14); // ano, mes, dia, hora, minuto e segundo.
            Console.WriteLine(data);
            Console.WriteLine(data.Year);
            Console.WriteLine(data.Month);
            Console.WriteLine(data.Day);
            Console.WriteLine(data.Hour);
        }
    }
   
}