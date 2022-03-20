using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IHex : MoveInstance
	{
		public IHex() : base( MoveHex.Instance ) {}
	}
}