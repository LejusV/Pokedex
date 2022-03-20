using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ISing : MoveInstance
	{
		public ISing() : base( MoveSing.Instance ) {}
	}
}