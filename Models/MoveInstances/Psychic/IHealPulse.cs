using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IHealPulse : MoveInstance
	{
		public IHealPulse() : base( MoveHealPulse.Instance ) {}
	}
}