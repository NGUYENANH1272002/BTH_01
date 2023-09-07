internal class Program
{
    private static void Main(String[] args)
    {
        const int a = 10;
        int b;
      System.Console.Write("gia tri b la: " );
        b=Convert.ToInt32(Console.ReadLine());
        int c = a + b;
        System.Console.WriteLine("c=" + c);
    }
}