using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models.SchoolViewModels;

public class CourseViewModel
{
    [Display(Name = "Номер")]
    public int CourseID { get; set; }

    [Display(Name = "Курс")]
    public string Title { get; set; }

    [Display(Name = "Credits")]
    public int Credits { get; set; }

    [Display(Name = "Кафедра")]
    public string DepartmentName { get; set; }
}
