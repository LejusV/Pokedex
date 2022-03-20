using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ITaunt : MoveInstance
	{
		public ITaunt() : base( MoveTaunt.Instance ) {}
	}
}