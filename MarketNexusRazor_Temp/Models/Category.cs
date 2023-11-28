using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MarketNexusRazor_Temp.Models
{
  
        public class Category
        {
            [Key]
            public int Id { get; set; }
            [Required]
            [MaxLength(30, ErrorMessage = "Campo Obrigatório")]
            [DisplayName("Nome")]
            public string? Name { get; set; }
            [DisplayName("Ordem de exibição")]
            [Range(1, 100, ErrorMessage = "Ordem de exibição precisa estar entre 1-100")]
            public int DisplayOrder { get; set; }

        }
    
}
