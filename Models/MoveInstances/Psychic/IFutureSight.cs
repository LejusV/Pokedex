using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IFutureSight : MoveInstance
	{
		public IFutureSight() : base( MoveFutureSight.Instance ) {}
	}
}