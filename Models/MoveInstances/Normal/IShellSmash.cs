using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IShellSmash : MoveInstance
	{
		public IShellSmash() : base( MoveShellSmash.Instance ) {}
	}
}