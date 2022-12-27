// See https://aka.ms/new-console-template for more information
using System.Text;

class TestClass
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int avg=0;
      for (int i = 0; i < 5; i++)
        {
            Console.Write("Введіть оцінку ");
            avg+=Convert.ToInt32(Console.ReadLine());
        }
        if (avg / 5 < 4)
        {
            Console.WriteLine("Студент не допущений");
        }
        else
        {
            Console.WriteLine("Студент  допущений");
        }

    }
}