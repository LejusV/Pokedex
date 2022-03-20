using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IPunishment : MoveInstance
	{
		public IPunishment() : base( MovePunishment.Instance ) {}
	}
}