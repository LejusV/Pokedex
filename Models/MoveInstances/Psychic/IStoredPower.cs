using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IStoredPower : MoveInstance
	{
		public IStoredPower() : base( MoveStoredPower.Instance ) {}
	}
}