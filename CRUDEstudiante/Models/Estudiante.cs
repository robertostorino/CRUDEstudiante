using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CRUDEstudiante.Models
{
    public class Estudiante
    {
        // todo lo que está entre [ ] son anotaciones que le dan más detalles a los atributos
        // son DataAnotations

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }

        [Display(Name = "Fecha inscripción")]
        public DateTime FechaInscripto { get; set; }

        [EnumDataType(typeof(Deporte))]
        public Deporte DeporteFavorito { get; set; }

    }
}
