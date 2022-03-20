using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ICloseCombat : MoveInstance
	{
		public ICloseCombat() : base( MoveCloseCombat.Instance ) {}
	}
}