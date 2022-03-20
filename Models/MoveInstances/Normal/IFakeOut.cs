using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IFakeOut : MoveInstance
	{
		public IFakeOut() : base( MoveFakeOut.Instance ) {}
	}
}