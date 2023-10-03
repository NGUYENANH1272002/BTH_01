namespace NewApp.Models;

    public class Person
    {
        public string FullName  {get; set;}
        public string Address  {get; set;}
        public int Age  {get; set;}
    public int GetYearOfBirth(int age)
    {
        int yearOfBirth = 2023-age;
        return yearOfBirth;
    }
    public void Nhap(){
            System.Console.Write("FullName: ");
            FullName = Console.ReadLine();
            System.Console.Write("Address: ");
            Address = Console.ReadLine();

        }
    

    public void HienThi()
    {
        System.Console.WriteLine("{0} + {1} + {2}" , FullName, Address, Age);
    }
 }
