using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ISpiderWeb : MoveInstance
	{
		public ISpiderWeb() : base( MoveSpiderWeb.Instance ) {}
	}
}