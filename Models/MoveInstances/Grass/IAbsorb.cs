using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IAbsorb : MoveInstance
	{
		public IAbsorb() : base( MoveAbsorb.Instance ) {}
	}
}