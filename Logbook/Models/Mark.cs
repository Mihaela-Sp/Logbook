namespace LogBook.Models
{
    public class Mark
    {
        public int Id { get; set; }
        public bool? Presence { get; set; }
        public int? Points { get; set; }
        public int? Bonus { get; set; }
        public string? Notes { get; set; }
        public int StudentId { get; set;}
        public int LessonId { get; set;}
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}
