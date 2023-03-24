using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM_Plus.Models
{
    public class Departamento
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe ingresar un nombre")]

        [Column(TypeName = "varchar(50)")]

        [Display(Name = "Departamento")]
        public string NombrePuesto { get; set; }

        [Required(ErrorMessage = "Debe ingresar una descripción")]

        [Column(TypeName = "varchar(50)")]

        [Display(Name = "Descripción")]
        public string DescripcionPuesto { get; set; }

        [Required(ErrorMessage = "Debe ingresar una ubicación")]

        [Column(TypeName = "varchar(50)")]

        [Display(Name = "Ubicación física")]
        public string UbicacionFisica { get; set; }

        [Display(Name = "Estado")]
        public bool isActivo { get; set; }
    }
}
