using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IExpandingForce : MoveInstance
	{
		public IExpandingForce() : base( MoveExpandingForce.Instance ) {}
	}
}