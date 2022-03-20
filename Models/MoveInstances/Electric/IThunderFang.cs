using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IThunderFang : MoveInstance
	{
		public IThunderFang() : base( MoveThunderFang.Instance ) {}
	}
}