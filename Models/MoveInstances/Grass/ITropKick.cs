using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ITropKick : MoveInstance
	{
		public ITropKick() : base( MoveTropKick.Instance ) {}
	}
}