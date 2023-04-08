namespace LogBook.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedOn { get; set;}
        public Mark? Mark { get; set; }
    }
}
