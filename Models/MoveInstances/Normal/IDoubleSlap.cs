using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IDoubleSlap : MoveInstance
	{
		public IDoubleSlap() : base( MoveDoubleSlap.Instance ) {}
	}
}