using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть дату (формат: дд.мм.рррр):");
        string dateString = Console.ReadLine();

        DateTime date;
        if (!DateTime.TryParseExact(dateString, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out date))
        {
            Console.WriteLine("Помилка! Невірний формат дати.");
            return;
        }

        string season = GetSeason(date);

        string dayOfWeek = date.ToString("dddd");

        Console.WriteLine($"{season} {dayOfWeek}");
    }

    static string GetSeason(DateTime date)
    {
        int month = date.Month;

        if (month >= 3 && month <= 5)
        {
            return "Spring";
        }
        else if (month >= 6 && month <= 8)
        {
            return "Summer";
        }
        else if (month >= 9 && month <= 11)
        {
            return "Autumn";
        }
        else
        {
            return "Winter";
        }
    }
}