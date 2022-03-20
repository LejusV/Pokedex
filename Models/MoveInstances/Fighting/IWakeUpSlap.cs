using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IWakeUpSlap : MoveInstance
	{
		public IWakeUpSlap() : base( MoveWakeUpSlap.Instance ) {}
	}
}