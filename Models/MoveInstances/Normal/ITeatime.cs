using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ITeatime : MoveInstance
	{
		public ITeatime() : base( MoveTeatime.Instance ) {}
	}
}