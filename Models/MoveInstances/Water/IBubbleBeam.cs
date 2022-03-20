using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IBubbleBeam : MoveInstance
	{
		public IBubbleBeam() : base( MoveBubbleBeam.Instance ) {}
	}
}