namespace LogBook.Models
{
    public class Student
    {

        public int id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public DateTime CreatedOn { get; set; }
        
        public Mark Mark { get; set; }  

    }
}
