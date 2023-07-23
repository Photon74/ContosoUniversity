using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models;

public class Instructor
{
    public int ID { get; set; }

    [Required]
    [Display(Name = "Фамилия")]
    [StringLength(50)]
    public string LastName { get; set; }

    [Required]
    [Column("FirstName")]
    [Display(Name = "Имя Отчество")]
    [StringLength(50)]
    public string FirstMidName { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Display(Name = "Дата найма")]
    public DateTime HireDate { get; set; }

    [Display(Name = "Полное имя")]
    public string FullName
    {
        get { return LastName + ", " + FirstMidName; }
    }

    public ICollection<Course> Courses { get; set; }
    public OfficeAssignment OfficeAssignment { get; set; }
}
