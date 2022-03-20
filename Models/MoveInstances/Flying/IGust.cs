using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IGust : MoveInstance
	{
		public IGust() : base( MoveGust.Instance ) {}
	}
}