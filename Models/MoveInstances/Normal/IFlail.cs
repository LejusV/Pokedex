using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IFlail : MoveInstance
	{
		public IFlail() : base( MoveFlail.Instance ) {}
	}
}