using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Data.Dtos
{
    public class CreateFilmeDto
    {
        [Required (ErrorMessage = "O campo TITULO é obrigatório")]
        public string Titulo { get; set; }
        [Required (ErrorMessage = "O campo DIRETOR é obrigatório")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O campo GENERO deve ter no máximo 30 caracteres")]
        public string Genero { get; set; }

        [Range(1, 500, ErrorMessage = "A DURAÇÃO deve ter no mínimo 1 e no máximo 500 minutos")]
        public int Duracao { get; set; }
    }
}