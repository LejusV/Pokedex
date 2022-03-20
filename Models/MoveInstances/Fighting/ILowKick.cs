using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ILowKick : MoveInstance
	{
		public ILowKick() : base( MoveLowKick.Instance ) {}
	}
}