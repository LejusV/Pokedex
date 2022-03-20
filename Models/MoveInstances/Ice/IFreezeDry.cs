using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IFreezeDry : MoveInstance
	{
		public IFreezeDry() : base( MoveFreezeDry.Instance ) {}
	}
}