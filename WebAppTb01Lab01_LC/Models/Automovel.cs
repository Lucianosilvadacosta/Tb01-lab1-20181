using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppTb01Lab01_LC.Models
{
    public class Automovel
    {
        //Propriedade(Primary key) - PK
        public int AutomovelId { get; set; }

        [Required(ErrorMessage = "Tipo é obrigatório")]
        public Tipo Tipo { get; set; }

        [Required(ErrorMessage = "Descrição é obrigatório")]
        [StringLength(300, ErrorMessage = "Máximo 300 caracteres")]
        public String Descricao { get; set; }

        [Required(ErrorMessage = "Marca é obrigatório")]
        [StringLength(300, ErrorMessage = "Máximo 300 caracteres")]
        public String Marca { get; set; }

        [Required(ErrorMessage = "Disponível é obrigatório")]
        public bool Disponivel { get; set; }

        [Required(ErrorMessage = "Data de cadastro é obrigatório")]
        public DateTime DataCadastro { get; set; }
    }
}
