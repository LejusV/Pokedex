using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IGyroBall : MoveInstance
	{
		public IGyroBall() : base( MoveGyroBall.Instance ) {}
	}
}