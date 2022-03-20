using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IAromaticMist : MoveInstance
	{
		public IAromaticMist() : base( MoveAromaticMist.Instance ) {}
	}
}