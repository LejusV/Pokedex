using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ISuckerPunch : MoveInstance
	{
		public ISuckerPunch() : base( MoveSuckerPunch.Instance ) {}
	}
}