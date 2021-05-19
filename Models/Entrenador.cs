using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreExp.Models
{
    public class Entrenador
    {
        [Key]
        public int EntrenadorId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Ciudad { get; set; }

        //AL ser un conjunto de pokemones hacemos un icollection y le pasamos la clase o objeto Pokemon
        public ICollection<Pokemon> ListPokemon { get; set; }
    }
}