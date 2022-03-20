using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IDefenseCurl : MoveInstance
	{
		public IDefenseCurl() : base( MoveDefenseCurl.Instance ) {}
	}
}