using System.ComponentModel.DataAnnotations;

namespace Relaciones_y_Controladores_Leccion3.Models.DataModels
{
    public class Course : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required, StringLength(280)]
        public string ShortDescription { get; set; } = string.Empty;

        [Required]
        public string LongDescription { get; set; } = string.Empty;
        public Level Level { get; set; } = Level.Basic;

        
        [Required]
        public ICollection<Category> Categories { get; set; } = new List<Category>();

        [Required]
        public ICollection<Student> Students { get; set; } = new List<Student>();

        [Required]
        public Chapter Chapters { get; set; } = new Chapter();
    }

    public enum Level
    {
        Basic,
        Medium,
        Advance,
        Expert
    }
}
