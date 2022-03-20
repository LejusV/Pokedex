using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IPowderSnow : MoveInstance
	{
		public IPowderSnow() : base( MovePowderSnow.Instance ) {}
	}
}