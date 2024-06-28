using System;
namespace DateTimeEmCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var data = DateTime.Now; //pega  a data de hoje
            //var data = new DateTime(2020, 10, 12, 8, 23, 14); // ano, mes, dia, hora, minuto e segundo.
            var data = DateTime.Now;
            var formatada = String.Format("{0:dd/MM/yyyy}", data);
            //var formatada = String.Format("{0}/{1}/{2}", data.Day, data.Month, data.Year); //formatação especifica do dia,mes e ano.
            Console.WriteLine(formatada);
        }
    }
   
}