using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IPlayNice : MoveInstance
	{
		public IPlayNice() : base( MovePlayNice.Instance ) {}
	}
}