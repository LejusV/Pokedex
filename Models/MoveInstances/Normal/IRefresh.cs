using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IRefresh : MoveInstance
	{
		public IRefresh() : base( MoveRefresh.Instance ) {}
	}
}