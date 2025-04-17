using _023_staticmethod;

class InsanceMethod
{
    static void Main()
    {
        Date bday = new Date();

        bday.year = 2003;
        bday.month = 9;
        bday.day = 30;

        Console.WriteLine("생일:{0}/{1}/{2}는 {3}일 쨰 되는 날입니다.", bday.year, bday.month, bday.day, bday.DayOfYear());

        Console.WriteLine(Date.IsLeapyear(2024));

    }
}