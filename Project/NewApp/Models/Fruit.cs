namespace NewApp.Models;
 
 public class Fruit {
        public string FruitName {get;set;}
        public string Infor {get; set;}


        // phuong thuc chua tham so-Fruit
        public int ThanhTien ( int Cannang)
        {
            int TT = Cannang *2;
            return TT;
        }
 }
 