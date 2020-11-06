using System;
using System.Globalization;
using System.IO;

namespace TimesheetGenerator
{
    public class TimesheetMaker
    {
        private string Day { get; set; }
        private string Month { get; set; }
        private string Year { get; set; }

        public TimesheetMaker(string day, string month, string year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public string CreateFile(string fileName)
        {
            var startingDate = DateTime.Parse($"{this.Month}/{this.Day}/{this.Year}");
            string path = $"{Environment.CurrentDirectory}\\{fileName}";


            using (StreamWriter sw = File.CreateText(path))
            {

                for (int i = 0; i < 7; i++)
                {
                    string date = $"{startingDate.ToLongDateString()}";
                    string timeStamps = "Log on - \nLunch - \nLog off - \n\n";
                    string separator = "------------------------------------";

                    WriteToFile(sw, date);
                    WriteToFile(sw, timeStamps);
                    WriteToFile(sw, separator);

                    startingDate = startingDate.AddDays(1);
                }
            }
            return startingDate.ToLongDateString();
        }

        private void WriteToFile(StreamWriter sw, string text)
        {
            sw.WriteLine(text);
        }

    }
}