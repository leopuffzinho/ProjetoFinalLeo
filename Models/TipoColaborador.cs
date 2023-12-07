using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinalLeo.Models
{
    [Table("TipoColaborador")]
    public class TipoColaborador
    {
        [Column("TipoColaboradorId")]
        [Display(Name = "Código do Tipo de Colaborador")]
        public int TipoColaboradorId { get; set; }

        [Column("TipoColaboradorNome")]
        [Display(Name = "Nome do Tipo de Colaborador")]
        public string TipoColaboradorNome { get; set; } = string.Empty;
    }
}
