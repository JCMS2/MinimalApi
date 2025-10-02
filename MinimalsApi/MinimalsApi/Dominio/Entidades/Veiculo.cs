using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinimalsApi.Dominio.Entidades
{
    public class Veiculo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Nome { get; set; } = default!;

        [StringLength(100)]
        public string Marca { get; set; } = default!;

        // Troquei o tipo de Stream para string, pois Stream não faz sentido para 'Perfil'

        public int Ano { get; set; } = default!;
    }
}
