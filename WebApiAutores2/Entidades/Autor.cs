﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApiAutores2.Validaciones;

namespace WebApiAutores2.Entidades
{
    public class Autor
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="El campo {0} es requerido")]
        [StringLength(maximumLength:120, ErrorMessage ="El campo {0} no debe tener mas de {1} caracteres")]
        [PrimeraLetraMayuscula]
        public string Nombre { get; set; }
        public List<AutorLibro> AutoresLibros { get; set; }

    }
}
