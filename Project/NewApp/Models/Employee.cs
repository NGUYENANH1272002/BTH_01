{
 public class Employee {
        public string FullName {get;set;}
        public string Address {get; set;}
        public string EmployeeID {get; set;}

        // phuong thuc co gia tri tra ve-Employee
        public Employee()
        {
            FullName = "Ho Ten ";
            Address ="Dia chi";
            EmployeeID ="Ma nv";
        }
        public int TinhLuong(int LuongCB)
            {
                
                int Luong = LuongCB + 120000;
                return Luong;
            }
         
    }
 }