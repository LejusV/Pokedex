using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IPurify : MoveInstance
	{
		public IPurify() : base( MovePurify.Instance ) {}
	}
}