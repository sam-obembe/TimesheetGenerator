using System;
using System.IO;

namespace TimesheetGenerator
{
    class Program
    {
        private static string Day;
        private static string Month;
        private static string Year;

        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Correct usage: dotnet run dd mm yyyy");
                Environment.Exit(1);
            }
            Day = args[0];
            Month = args[1];
            Year = args[2];

            var timeSheetMaker = new TimesheetMaker(Day, Month, Year);

            var fileName = $"{Month}-{Day}_Timesheet.txt";
            timeSheetMaker.CreateFile(fileName);
        }

    }
}
