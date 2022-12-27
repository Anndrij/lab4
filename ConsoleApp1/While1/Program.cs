// See https://aka.ms/new-console-template for more information
using System.Text;

class TestClass
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int n = 0;
        Console.Write("Введіть число ");
        n = Convert.ToInt32(Console.ReadLine());
        double a=0, b=0, c=0;
        for(int i = n; i > 0; i--)
        {
            a += Math.Pow(-1, i)/(2*i+1);
        }
        Console.WriteLine($"a={a}");
        for (int i = n; i > 0; i--)
        {
            b += 1+1/Math.Pow(i,2);
        }
        Console.WriteLine($"b={b}");
        for (int i = n; i > 0; i--)
        {
            c += Factorial(i);
        }
        Console.WriteLine($"c={c}");
    }

    public static int Factorial(int n)
    {
        if (n == 1) return 1;

        return n * Factorial(n - 1);
    }
}
