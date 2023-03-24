using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM_Plus.Models
{
    public class TipoTransaccion
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe ingresar un nombre")]

        [Column(TypeName = "varchar(50)")]

        [Display(Name = "Tipo de Transacción")]
        public string NombreTipoTransaccíon { get; set; }

        [Required(ErrorMessage = "Debe ingresar una descripción")]

        [Column(TypeName = "varchar(50)")]

        [Display(Name = "Descripción")]
        public string DescripcionTipoTransaccion { get; set; }

        [Display(Name = "Estado")]

        public bool isActivo { get; set; }
    }
}
