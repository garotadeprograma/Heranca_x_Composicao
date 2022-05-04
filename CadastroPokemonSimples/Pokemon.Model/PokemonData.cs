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

    public class ShowPokemonStatus
    {
        public ShowPokemonStatus()
        {
            var pokemon1 = new PokemonStatus
            {
                Id = 1,
                Nome = "Squirtle",
                Tipo = "Água",
                isHurt = false
            };

            var pokemon2 = new PokemonStatusComposition
            {
                pokemon = new PokemonData()
                {
                    Id = 2,
                    Nome = "Bulbassauro",
                    Tipo = "Planta"
                },
                isHurt = false
            };
        }
    }
}


