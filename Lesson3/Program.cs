using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Введите интервал:");
        //string a = Console.ReadLine();
        //string b = Console.ReadLine();
        //int n1 = int.Parse(a);
        //int n2 = int.Parse(b);
        //for (int xn = n1; xn < n2; xn = xn + 1)
        //{
        //    int y = ChangNum(xn);
        //    Console.WriteLine(y);
        //}
        //static int ChangNum(int x)
        //{
        //    int y = (x - 1) * (x - 1) - 5;
        //    return y;
        //}
        Student Student1 = new Student();
        Student1.Health = 100;
        Student1.Knowledge = 50;
        Student1.Behappiness();
        Student1.Tostudy();
    }
}
 public class Student
    {
        public int Health;
        public byte Happiness;
        public int Intelligence;
        public int Knowledge;

    
    public void  Behappiness()
    {
        Knowledge -= 10;
        Console.WriteLine($"Студент веселился. Знание: {Knowledge}");
    }
    public void Tostudy ()
    {
        Intelligence += 10;
        Knowledge += 10;
        Console.WriteLine($"Студент учится. Знание: {Knowledge}, Интеллект: {Intelligence}");
    }
}