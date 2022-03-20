using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IConversion : MoveInstance
	{
		public IConversion() : base( MoveConversion.Instance ) {}
	}
}