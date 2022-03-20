using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IEerieSpell : MoveInstance
	{
		public IEerieSpell() : base( MoveEerieSpell.Instance ) {}
	}
}