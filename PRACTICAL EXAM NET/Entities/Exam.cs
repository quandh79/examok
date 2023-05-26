using System.ComponentModel.DataAnnotations;

namespace PRACTICAL_EXAM_NET.Entities
{
    public class Exam
    {
        [Key]
        public int ExamId { get; set; }
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Exam Date")]
        public DateTime ExamDate { get; set; }

        [DataType(DataType.Time)]
        [Display(Name = "Exam Duration")]
        public TimeSpan ExamDuration { get; set; }
        public virtual ICollection<Subject> subjects { get; set; } = new List<Subject>();
        public virtual ICollection<Class> classes { get; set; } = new List<Class>();
        public virtual ICollection<Faculty> faculty { get; set; } = new List<Faculty>();
      
       
    }
}
