using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IAirCutter : MoveInstance
	{
		public IAirCutter() : base( MoveAirCutter.Instance ) {}
	}
}