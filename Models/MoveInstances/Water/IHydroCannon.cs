using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IHydroCannon : MoveInstance
	{
		public IHydroCannon() : base( MoveHydroCannon.Instance ) {}
	}
}