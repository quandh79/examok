using System.ComponentModel.DataAnnotations;

namespace PRACTICAL_EXAM_NET.Entities
{
    public class Class
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Lop hoc khong duoc de trong")]
        [StringLength(255, ErrorMessage = "ExamSubject phải là một chuỗi có độ dài tối đa là 255.")]
        public string Name { get; set; }
        public virtual ICollection<Exam> exams { get; set; } = new List<Exam>();
    }
}
