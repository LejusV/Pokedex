using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IHydroPump : MoveInstance
	{
		public IHydroPump() : base( MoveHydroPump.Instance ) {}
	}
}