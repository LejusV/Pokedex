using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IHappyHour : MoveInstance
	{
		public IHappyHour() : base( MoveHappyHour.Instance ) {}
	}
}