using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IFlameWheel : MoveInstance
	{
		public IFlameWheel() : base( MoveFlameWheel.Instance ) {}
	}
}