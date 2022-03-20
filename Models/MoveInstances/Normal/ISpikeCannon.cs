using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ISpikeCannon : MoveInstance
	{
		public ISpikeCannon() : base( MoveSpikeCannon.Instance ) {}
	}
}