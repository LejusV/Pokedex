using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ISolarBeam : MoveInstance
	{
		public ISolarBeam() : base( MoveSolarBeam.Instance ) {}
	}
}