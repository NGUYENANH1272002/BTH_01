internal class Program
{
    private static void Main(String[] args)
    {
        int a;
        System.Console.Write("gia tri cua a la: ");
        a = Convert.ToInt32(Console.ReadLine());
        int b;
        System.Console.Write("gia tri cua b la: ");
        b = Convert.ToInt32(Console.ReadLine());
        int c = a - b;
        int d = a * b;
        int e = a / b;
        int f = a % b;
        System.Console.WriteLine("gia tri cua c= " + c);
        System.Console.WriteLine("gia tri cua d= " + d);
        System.Console.WriteLine("gia tri cua e= " + e);
        System.Console.WriteLine("va phan du la: " + f);

    }
}