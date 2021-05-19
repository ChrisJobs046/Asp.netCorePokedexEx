using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreExp.Models
{
    public class Pokemon
    {
        [Key]
        public int PokemonId { get; set; }
        public string Nombre { get; set; }
        public string Origen { get; set; }
        public string Naturaleza { get; set; }
        public int EntrenadorId { get; set; }
        public Entrenador Entrenador { get; set; }
    }
}