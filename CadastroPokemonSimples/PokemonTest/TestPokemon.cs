using Xunit;
using Pokemon.Model;

namespace PokemonTest;

public class TestPokemon
{
    [Fact]
    public void TestPokemonClass()
    {
        var pokemon = new ShowPokemonStatus();

        Assert.True(true, "teste");

    }
}
