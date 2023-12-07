using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
namespace ProjetoFinalLeo.Models
{
    [Table("ProcedimentoRealizado")]
    public class ProcedimentoRealizado
    {
        [Column("ProcedimentoId")]
        [Display(Name = "Código do ProcedimentoRealizado")]
        public int ProcedimentoRealizadoId { get; set; }

        [ForeignKey("ClienteId")]
        public int? ClienteId { get; set; }

        public Cliente? Cliente { get; set; }

        [ForeignKey("ProcedimentoId")]
        public int? ProcedimentoId { get; set; }

        public Procedimento? Procedimento { get; set; }

        [ForeignKey("ColaboradorId")]
        public int? ColaboradorId { get; set; }

        public Colaborador? Colaborador { get; set; }

        [ForeignKey("LocalRealizacaoId")]
        public int?  LocalRealizacaoId { get; set; }

        [Display(Name = "Local da Realização")]

        public LocalRealizacao? LocalRealizacao { get; set; }

        [Column("DataRealizacao")]
        [Display(Name = "Data da Realização")]
        public DateTime DataRealizacao { get; set; }

        [Column("ObservacaoRealizacao")]
        [Display(Name = "Observação")]
        public string ObservacaoRealizacao { get; set; } = string.Empty;
    }
}
