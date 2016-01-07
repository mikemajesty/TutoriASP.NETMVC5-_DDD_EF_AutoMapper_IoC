using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModelo.MVC.ViewModel
{
    public class ProductViewModel
    {
        [Key]
        public int ProductID { get; set; }
        [Required(ErrorMessage = "Preencha o campo {0}")]
        [MaxLength(150, ErrorMessage = "Máximo requerido para {0} é 150 caracteres")]
        [MinLength(2, ErrorMessage = "Míximo requerido para {0} é 2 caracteres")]
        public string Nome { get; set; }
        [Range(typeof(decimal),"0","99999999999",ErrorMessage ="Valor fora do range")]
        [DataType(DataType.Currency,ErrorMessage ="Valor não corresponde a um valor numerico")]
        [Required(ErrorMessage ="Valor requerido")]
        public decimal Value { get; set; }
        [DisplayName("Available?")]
        public bool Available { get; set; }
        public int ClientID { get; set; }
        public virtual ClientViewModel Client { get; set; }
    }
}