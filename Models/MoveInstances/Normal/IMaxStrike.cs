using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IMaxStrike : MoveInstance
	{
		public IMaxStrike() : base( MoveMaxStrike.Instance ) {}
	}
}