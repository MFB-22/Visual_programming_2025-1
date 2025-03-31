namespace _003_bmiCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double weight, height;
            //Console.Write("키(cm) 입력: ");
            //height = double.Parse(Console.ReadLine());
            //Console.Write("체중(kg) 입력: ");
            //weight = double.Parse(Console.ReadLine());

            //double bmi = weight / (height / 100 * height / 100);

            //Console.Write("BMI = " + bmi);
            Console.Write("키(cm) 입력: ");
            string s = Console.ReadLine();
            double h = double.Parse(s);

            Console.Write("체중(kg) 입력: ");
            s = Console.ReadLine();
            double w = double.Parse(s);

            h /= 100;
            double bmi = w / (h * h);
            Console.WriteLine("BMI = " + bmi);
        }
    }
}
