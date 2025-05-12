namespace Practice3.Task7
{
    enum Months
    {
        January,
        Fevraly,
        Marth,
        April,
        May,
        June,
        July,
        August,
        Semptember,
        Octember,
        November,
        Decamber
    }

    class Start
    {
        static int days_mouth(Months months)
        {
            int days = 0;
            switch (months)
            {
                case Months.January:
                    days = 31;
                    break;
                case Months.Fevraly:
                    days = 28;
                    break;
                case Months.Marth:
                    days = 31;
                    break;
                case Months.April:
                    days = 30;
                    break;
                case Months.May:
                    days = 31;
                    break;
                case Months.June:
                    days = 30;
                    break;
                case Months.July:
                    days = 31;
                    break;
                case Months.August:
                    days = 31;
                    break;
                case Months.Semptember:
                    days = 30;
                    break;
                case Months.Octember:
                    days = 31;
                    break;
                case Months.November:
                    days = 30;
                    break;
                case Months.Decamber:
                    days = 31;
                    break;
            }
            return days;
        }

        static void Main()
        {
            string month = Console.ReadLine();
            Months months = new Months();

            months = month switch
            {
                "январь" => Months.January,
                "февраль" => Months.Fevraly,
                "март" => Months.Marth,
                "апрель" => Months.April,
                "май" => Months.May,
                "июнь" => Months.June,
                "июль" => Months.July,
                "август" => Months.August,
                "сентябрь" => Months.Semptember,
                "октябрь" => Months.Octember,
                "ноябрь" => Months.November,
                "декабрь" => Months.Decamber,
            };

            Console.WriteLine($"{months} day = " +
                $"{days_mouth(months)}");
        }
    }
}
