class Rectangle
{
    private double width,height;
    public Rectangle(double w, double h){ width = w; height = h; }
    public Rectangle(){ width = 0; height = 0; }
    public void Width(int w)
    {
        if (w > 0)
            width = w;
        else
        {
            height = 0;
            Console.WriteLine("0보다 큰 값을 사용하세요");
        }
    }
    public void Height(int h)
    {
        if (h > 0)
            height = h;
        else
        {
            width = 0;
            Console.WriteLine("0보다 큰 값을 사용하세요");
        }
    }
    public double getarea(){ return width * height; }
    public double getperimeter(){ return 2 * (width + height); }
}

class program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle(5, 3);
        double area = rect.getarea();
        double perimeter = rect.getperimeter();
        Console.WriteLine("넓이: " + area);
        Console.WriteLine("둘레: " + perimeter);
    }
}
//class rectangle
//{
//    private int width, height;
//    public rectangle(int w, int h)
//    {
//        width = w; height = h;
//    }
//    public rectangle()
//    {
//        width = 0; height = 0;
//    }
//    public int Getarea() { return width * height; }
//    public int Getperimeter() { return width * 2 + height * 2; }
//    public void setwidth(int w)
//    {
//        if (w > 0)
//            width = w;
//        else
//        {
//            height = 0;
//            Console.WriteLine("0보다 큰 값을 사용하세요");
//        }
//    }
//    public void setheight(int h)
//    {
//        if (h > 0)
//            height = h;
//        else
//        {
//            width = 0;
//            Console.WriteLine("0보다 큰 값을 사용하세요");
//        }
//    }
//}
//internal class program
//{
//    static void main(string[] args)
//    {
//        rectengle rect = new rectengle();
//        Console.Write("가로길이:");
//        int w = int.Parse(Console.readline());
//        Console.Write("세로길이:");
//        int h = int.Parse(Console.readline());
//        rect.setwidth(w);
//        rect.setheight(h);
//        Console.WriteLine("넓이 : [0]", rect.getarea());
//        Console.WriteLine("둘레 : [0]", rect.getperimeter());
//    }
//}