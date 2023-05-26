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
        public int? classesId { get; set; }
        public int? facultysId { get; set; }
        public int? subjectsId { get; set; }
        public string? status { get; set; }
        
        public virtual Class classes { get; set; }
        public virtual Subject subjects { get; set; }
        public virtual Faculty facultys { get; set; }


    }
}
