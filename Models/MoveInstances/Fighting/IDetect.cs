using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IDetect : MoveInstance
	{
		public IDetect() : base( MoveDetect.Instance ) {}
	}
}