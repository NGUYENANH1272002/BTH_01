int n;
System.Console.Write("n = ");
n = Convert.ToInt16(Console.ReadLine());

int[] intArr = new int[n];


for (int i = 0; i < intArr.Length; i++)
{
    intArr[0] = 2;
    intArr[i] = i*2;


}
for (int i = 0; i < intArr.Length; i++){
    System.Console.WriteLine("Mang[" + i + "] = " + intArr[i]);}