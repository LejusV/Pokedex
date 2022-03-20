using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IRoost : MoveInstance
	{
		public IRoost() : base( MoveRoost.Instance ) {}
	}
}