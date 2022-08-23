using System.ComponentModel.DataAnnotations;

namespace Relaciones_y_Controladores_Leccion3.Models.DataModels
{
    public class Category : BaseEntity
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        public ICollection<Course> Courses  { get; set; } = new List<Course>();
    }
}
