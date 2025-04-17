namespace _022_class2
{
    class Product
    {
        public string? name;
        public int price;
    }
    class Mymath
    {
        public static double PI = 3.14;
    }
    class Mycalendar
    {
        public const int months = 12;
        public const int weeks = 52;
        public const int days = 365;

        public const double daysperweek = (double)days / weeks;
        public const double dayspermonth = (double)days / months;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Product의 객체 p를 만들고, p의 이름은 "시계", 가격은 10만원

            Product p = new Product();
            p.name = "시계"; //p의 이름을 "시계"로 설정
            p.price = 100000; //p의 가격을 10만원으로 설정


            Console.WriteLine("{0}, {1}",p.name,p.price);
            Console.WriteLine("원주율: {0}", Mymath.PI);
            Console.WriteLine("한달은 평균 {0:F3}일", Mycalendar.dayspermonth);
        }
    }
}