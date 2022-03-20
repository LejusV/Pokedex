using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IFlamethrower : MoveInstance
	{
		public IFlamethrower() : base( MoveFlamethrower.Instance ) {}
	}
}