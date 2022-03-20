using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IPresent : MoveInstance
	{
		public IPresent() : base( MovePresent.Instance ) {}
	}
}