using System.Data;
using System.Runtime.CompilerServices;

class student
{
    private string name;
    private int age;
    private string major;

    public string Name
    {
        get { return name; }
        set
        {
            if (!string.IsNullOrEmpty(value))
                name = value;
            else
                throw new ArgumentException("이름은 비어 있을수 없습니다.");
        }
    }
    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0)
                age = value;
            else
                throw new ArgumentException("나이는 음수일 수 없습니다.");
        }
    }

    public string Major
    {
        get { return major; }
        set
        {
            if (!string.IsNullOrEmpty(value))
                major = value;
            else
                throw new ArgumentException("전공은 비어있을 수 없습니다.");
        }
    }
    public student(string name, int age, string major)
    {
        Name = name;
        Age = age;
        Major = major;
        
    }
    public void DisplayInfo()
    {
        Console.WriteLine("이름: " + Name);
        Console.WriteLine("나이: " + Age);
        Console.WriteLine("전공: " + Major);
    }
}

class program
{
    static void Main(string[] args)
    {
        student s = new student("정동현", 23, "의료IT공학");
        s.DisplayInfo();
    }
}