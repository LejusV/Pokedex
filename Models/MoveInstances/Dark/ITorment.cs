using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ITorment : MoveInstance
	{
		public ITorment() : base( MoveTorment.Instance ) {}
	}
}