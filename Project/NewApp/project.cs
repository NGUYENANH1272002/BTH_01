using NewApp.Models;

public class project{   
     public static void Main(String[] args){
     Fruit frt = new Fruit();
       string FruitName ="Dua hau";
       int b = 20000 ;
       
       Console.WriteLine("{0}  thanh tien la: {1} ", FruitName, frt.ThanhTien(b));
    }
}