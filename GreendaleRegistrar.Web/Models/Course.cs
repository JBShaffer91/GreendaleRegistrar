using System.ComponentModel.DataAnnotations;

namespace GreendaleRegistrar.Models
{
  public class Course
  {
    public int Id { get; set; }

    [Required]
    [Display(Name = "Course Name")]
    public string? Name { get; set; }

    [Required]
    [Display(Name = "Course Number")]
    public string? Number { get; set; }
  }
}
