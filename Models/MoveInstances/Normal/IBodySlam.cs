using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IBodySlam : MoveInstance
	{
		public IBodySlam() : base( MoveBodySlam.Instance ) {}
	}
}