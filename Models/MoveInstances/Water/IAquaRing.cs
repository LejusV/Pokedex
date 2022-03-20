using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IAquaRing : MoveInstance
	{
		public IAquaRing() : base( MoveAquaRing.Instance ) {}
	}
}