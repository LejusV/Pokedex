using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IOriginPulse : MoveInstance
	{
		public IOriginPulse() : base( MoveOriginPulse.Instance ) {}
	}
}