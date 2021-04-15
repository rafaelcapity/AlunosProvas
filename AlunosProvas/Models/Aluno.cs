using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AlunosProvas.Models
{   
    [Table("Alunos")]
    public class Aluno
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome Obrigatorio")]
        [Display(Name = "Nome:")]
        public string nome { get; set; }

        [Required(ErrorMessage = "CPF Obrigatorio")]
        [Display(Name = "CPF:")]
        public string cpf { get; set; }

        [Required(ErrorMessage = "Curso Obrigatorio")]
        [Display(Name = "Cidade:")]
        public string cidade { get; set; }

        [Required(ErrorMessage = "Data Obrigatorio")]
        [Display(Name = "Idade")]
        public int idade { get; set; }

        [Required(ErrorMessage = "Curso Obrigatorio")]
        [Display(Name = "bolsista :")]
        public string  nomeMae { get; set; }

    }
}
