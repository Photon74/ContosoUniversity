using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models;

public class Student
{
    public int ID { get; set; }

    [Required]
    [StringLength(50)]
    [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
    [Display(Name = "Фамилия")]
    public string LastName { get; set; }

    [Required]
    [StringLength(50, ErrorMessage = "Длинна имени не более 50-ти символов!")]
    [Column("FirstName")]
    [Display(Name = "Имя Отчество")]
    public string FirstMidName { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
    [Display(Name = "Дата зачисления")]
    public DateTime EnrollmentDate { get; set; }

    [DisplayName("Полное Имя")]
    public string FullName
    {
        get
        {
            return LastName + ", " + FirstMidName;
        }
    }

    [Display(Name = "Курсы")]
    public ICollection<Enrollment> Enrollments { get; set; }
}
