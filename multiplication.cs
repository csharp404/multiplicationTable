// Yousef
// [05/11/2024]
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a number :");
        int num = -1;
        if(int.TryParse(Console.ReadLine(),out int n))
        {
            num = n;
        }
        Console.WriteLine($"Multiplication table for {num} :");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{num} * {i} = {num*i}");
        }
    }
}