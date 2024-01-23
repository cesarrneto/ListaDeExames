using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamesClinpop_Lista.Data
{
    public class Exame
    {
        [Key]
        public int ExameId { get; set; }

		
		[MaxLength(100)]
        public string? NomeExame { get; set; }

		
		[MaxLength(200)]
        public string? DescricaoExame { get; set; }

		
		[Column(TypeName = "decimal(12,2)")]
        public decimal PrecoExame { get; set; }
    }
}
