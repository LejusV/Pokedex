using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IFacade : MoveInstance
	{
		public IFacade() : base( MoveFacade.Instance ) {}
	}
}