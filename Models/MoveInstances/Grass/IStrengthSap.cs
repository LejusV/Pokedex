using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IStrengthSap : MoveInstance
	{
		public IStrengthSap() : base( MoveStrengthSap.Instance ) {}
	}
}