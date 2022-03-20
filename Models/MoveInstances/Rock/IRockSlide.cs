using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IRockSlide : MoveInstance
	{
		public IRockSlide() : base( MoveRockSlide.Instance ) {}
	}
}