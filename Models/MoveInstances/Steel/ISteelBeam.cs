using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ISteelBeam : MoveInstance
	{
		public ISteelBeam() : base( MoveSteelBeam.Instance ) {}
	}
}