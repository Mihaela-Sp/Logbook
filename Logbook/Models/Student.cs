namespace LogBook.Models
{
    public class Student
    {

        public int id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public bool Presence { get; set; }
        public int Marks { get; set; }
        public int Bonus { get; set; }
        public string Lesson { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedOn { get; set; }

    }
}
