using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IIngrain : MoveInstance
	{
		public IIngrain() : base( MoveIngrain.Instance ) {}
	}
}