using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Modulo3.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="O nome é obrigatorio")]
        [StringLength(maximumLength:50,ErrorMessage = "O nome deve ter no maximo 50 caracteres")]
        public string Nome { get; set; }
        public string Sexo { get; set; }
        [Required(ErrorMessage ="O email deve ser informado")]
        [EmailAddress(ErrorMessage ="Formato invalido de email")]
        public string Email { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        [Required(ErrorMessage ="Campo obrigatorio")]
        public DateTime Nascimento { get; set; }
    }
}
