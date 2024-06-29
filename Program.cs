using System;
using System.Globalization;

namespace DateTimeEmCsharp

{
    class Program
    {
        static void Main(string[] args)
        {
            var data = DateTime.Now;

            //var data = DateTime.Now; //pega  a data de hoje
            //var data = new DateTime(2020, 10, 12, 8, 23, 14); // ano, mes, dia, hora, minuto e segundo.
            
            //var formatada = String.Format("{0:s}", data); //formato muito utilizado de pattern para mandar um json, mto ultilizado tb em sql
            //var formatada = String.Format("{0:t}", data); //short time pattern, vai exibir apenas ahora
            //var formatada = String.Format("{0:D}", data); //vai exibir a data por extenso
            //var formatada = String.Format("{0:dd/MM/yyyy  hh:mm:ss}", data);
            //var formatada = String.Format("{0}/{1}/{2}", data.Day, data.Month, data.Year); //formatação especifica do dia,mes e ano.

            //Console.WriteLine(data.AddDays(1));
            //Console.WriteLine(data.AddMonths(1));
            //Console.WriteLine(data.AddYears(1));

            // if(data.Date == DateTime.Now.Date){
            //     Console.WriteLine("é igual");
            // } 

            // var ptBr = new CultureInfo("pt-BR");
            // var enUs = new CultureInfo("en-US");
            // var de = new CultureInfo("de-DE");

            // Console.WriteLine(data.ToString("D"));
            // Console.WriteLine(data.ToString("D", de));
            // Console.WriteLine(data.ToString("D", enUs));
            // Console.WriteLine(data.ToString("D", ptBr));
            
            var utcDate = DateTime.UtcNow;
            // Console.WriteLine(utcDate);
            // Console.WriteLine(utcDate.ToLocalTime());

            // var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            // var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia);

            // Console.WriteLine(horaAustralia);
        }
    }
   
}