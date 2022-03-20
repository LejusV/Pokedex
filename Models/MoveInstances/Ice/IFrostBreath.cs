using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IFrostBreath : MoveInstance
	{
		public IFrostBreath() : base( MoveFrostBreath.Instance ) {}
	}
}