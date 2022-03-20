using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IFlash : MoveInstance
	{
		public IFlash() : base( MoveFlash.Instance ) {}
	}
}