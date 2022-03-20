using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IMindReader : MoveInstance
	{
		public IMindReader() : base( MoveMindReader.Instance ) {}
	}
}