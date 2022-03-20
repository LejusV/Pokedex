using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IRecover : MoveInstance
	{
		public IRecover() : base( MoveRecover.Instance ) {}
	}
}