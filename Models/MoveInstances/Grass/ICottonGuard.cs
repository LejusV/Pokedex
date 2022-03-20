using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ICottonGuard : MoveInstance
	{
		public ICottonGuard() : base( MoveCottonGuard.Instance ) {}
	}
}