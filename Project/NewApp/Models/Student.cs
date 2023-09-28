namespace NewApp.Models
 {
 public class Students  {
        public string Name {get;set;}
        public string Address {get; set;}
        public string StudentID {get; set;}
        
        
   
    // phuong co gia tri tra ve-student
        public Students ()
        {
            Name = "ho ten mac dinh";
            Address =" Thai Nguyen";
            StudentID ="2021050085";
        }
        public int GetYearOfBirth(int age)
    {
        int yearOfBirth = 2023-age;
        return yearOfBirth;
    }

      
    }
 }