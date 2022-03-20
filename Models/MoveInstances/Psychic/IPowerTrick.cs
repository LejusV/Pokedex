using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IPowerTrick : MoveInstance
	{
		public IPowerTrick() : base( MovePowerTrick.Instance ) {}
	}
}