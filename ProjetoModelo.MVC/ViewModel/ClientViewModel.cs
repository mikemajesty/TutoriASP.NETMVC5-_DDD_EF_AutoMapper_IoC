using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModelo.MVC.ViewModel
{
    public class ClientViewModel
    {
        [Key]
        public int ClientID { get; set; }
        [Required(ErrorMessage ="Preencha o campo {0}")]
        [MaxLength(150,ErrorMessage ="Máximo requerido para {0} é 150 caracteres")]
        [MinLength(2, ErrorMessage = "Míximo requerido para {0} é 2 caracteres")]
        public string Name { get; set; }
        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Preencha o campo {0}")]
        [MaxLength(150, ErrorMessage = "Máximo requerido para {0} é 150 caracteres")]
        [MinLength(2, ErrorMessage = "Míximo requerido para {0} é 2 caracteres")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Preencha o campo {0}")]
        [MinLength(4, ErrorMessage = "Míximo requerido para {0} é 4 caracteres")]
        [EmailAddress(ErrorMessage ="Email inválido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DateRegister { get; set; } = DateTime.Now;
        public bool Ativo { get; set; }
        public IEnumerable<ProductViewModel> Product { get; set; }
        public bool SpecialClient(ClientViewModel client)
        {
            return client.Ativo && DateTime.Now.Year - client.DateRegister.Year >= 5;
        }
    }
}