using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IVCreate : MoveInstance
	{
		public IVCreate() : base( MoveVCreate.Instance ) {}
	}
}