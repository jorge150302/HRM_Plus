using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM_Plus.Models
{
    public class Puesto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe ingresar un nombre")]

        [Column(TypeName = "varchar(50)")]

        [Display(Name = "Puesto")]
        public string NombrePuesto { get; set; }

        [Required(ErrorMessage = "Debe ingresar una descripción")]

        [Column(TypeName = "varchar(50)")]

        [Display(Name = "Descripcion")]
        public string DescripcionPuesto { get; set; }

        [Required(ErrorMessage = "Debe ingresar un nivel de riesgo")]

        [Display(Name = "Nivel de riesgo")]
        public string NivelRiesgo { get; set; }

        [Required(ErrorMessage = "Debe ingresar un monto")]

        [RegularExpression(@"[0-9]*\.?[0-9]*", ErrorMessage = "Solo números")]

        [Column(TypeName = "decimal(18,2)")]

        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal SalarioMinimo { get; set; }

        [Required(ErrorMessage = "Debe ingresar un monto")]

        [RegularExpression(@"[0-9]*\.?[0-9]*", ErrorMessage = "Solo números")]

        [Column(TypeName = "decimal(18,2)")]

        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal SalarioMaximo { get; set; }

        public bool isActivo { get; set; }
    }
}
