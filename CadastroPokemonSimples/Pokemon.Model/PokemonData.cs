using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokemon.Model
{
    public class PokemonData
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Tipo { get; set; }
    }

    public class PokemonStatus : PokemonData
    {
         public bool isHurt { get; set; }
    }

    public class PokemonStatusComposition
    {
        public PokemonData pokemon { get; set; }

        public bool isHurt { get; set; }

    }
}


