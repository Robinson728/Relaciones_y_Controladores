using System.ComponentModel.DataAnnotations;

namespace Relaciones_y_Controladores_Leccion3.Models.DataModels
{
    public class Chapter : BaseEntity
    {
        [Required]
        public string List { get; set; }
        public int CourseId { get; set; }
        public virtual Course Course { get; set; } = new Course();
    }
}
