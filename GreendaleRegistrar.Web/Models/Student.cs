using System;
using System.ComponentModel.DataAnnotations;

namespace GreendaleRegistrar.Models
{
  public class Student
  {
    public int Id { get; set; }

    [Required]
    [Display(Name = "Full Name")]
    public string? Name { get; set; }

    [Required]
    [Display(Name = "Enrollment Date")]
    public DateTime EnrollmentDate { get; set; }
  }
}
