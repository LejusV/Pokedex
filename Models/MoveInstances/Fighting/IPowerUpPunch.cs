using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IPowerUpPunch : MoveInstance
	{
		public IPowerUpPunch() : base( MovePowerUpPunch.Instance ) {}
	}
}