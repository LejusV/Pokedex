using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IFakeTears : MoveInstance
	{
		public IFakeTears() : base( MoveFakeTears.Instance ) {}
	}
}