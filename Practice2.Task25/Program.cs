using System;
using System.Diagnostics.Metrics;

namespace Practice2
{
    class Start
    {
        enum DayWeek
        {
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday
        }

        static void Main(string[] args)
        {
            //foreach (var arg in Enum.GetValues(typeof(DayWeek)))
            //{
            //    Console.WriteLine((DayWeek)arg);
            //}
            int select_enum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((DayWeek)select_enum - 1);
        }
    }
}