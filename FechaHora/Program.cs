using System;

namespace FechaHora
{
    class Program
    {
        static void Main(string[] args)
        {
            // DATE
            Console.Write("Escribe una fecha: ");
            string previousDateString = Console.ReadLine();
            //Le pasamos la fecha con este formato
            Console.Write("Que formato quieres usar: ");
            string formatoFecha = Console.ReadLine();

            if (formatoFecha.Length < 1)
            {
                formatoFecha = "d/m/yy";
            }

            DateTime previousDate = DateTime.ParseExact(previousDateString, formatoFecha, null);
            TimeSpan fromPrevousDate = DateTime.Now.Subtract(previousDate);

            if (fromPrevousDate.Ticks < 0)
            {
                Console.WriteLine($"{previousDateString} es {Math.Round(fromPrevousDate.TotalDays,0, MidpointRounding.AwayFromZero)} en el futuro");
            }
            else
            {
                Console.WriteLine($"Han sido {fromPrevousDate.Days} since {previousDateString}");
            }

            Console.ReadLine();

            //hora
            /*Console.Write("Escribe una hora: ");
            string previousTimeString = Console.ReadLine();
            //tt indica am o pm
            Console.Write("Que formato quieres usar?");
            string timeFormat = Console.ReadLine();
            if (timeFormat.Length < 1)
            {
                timeFormat = "h:mm tt";
            }
            DateTime previousTime = DateTime.ParseExact(previousTimeString, timeFormat, null);
            TimeSpan fromPrevousTime = DateTime.Now.Subtract(previousTime);
            if (fromPrevousTime.Ticks < 0)
            {
                fromPrevousTime = fromPrevousTime.Add(TimeSpan.FromHours(24));
            }
            Console.WriteLine($"{previousTimeString} han pasado {fromPrevousTime.Hours} horas y {fromPrevousTime.Minutes} minutes.");
            Console.ReadLine();*/
        }
    }
}
