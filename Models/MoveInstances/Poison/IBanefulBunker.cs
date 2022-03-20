using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IBanefulBunker : MoveInstance
	{
		public IBanefulBunker() : base( MoveBanefulBunker.Instance ) {}
	}
}