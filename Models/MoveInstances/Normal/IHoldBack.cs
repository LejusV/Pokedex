using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IHoldBack : MoveInstance
	{
		public IHoldBack() : base( MoveHoldBack.Instance ) {}
	}
}