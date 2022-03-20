using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ICurse : MoveInstance
	{
		public ICurse() : base( MoveCurse.Instance ) {}
	}
}