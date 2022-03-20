using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IThunderShock : MoveInstance
	{
		public IThunderShock() : base( MoveThunderShock.Instance ) {}
	}
}