using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ILeechLife : MoveInstance
	{
		public ILeechLife() : base( MoveLeechLife.Instance ) {}
	}
}