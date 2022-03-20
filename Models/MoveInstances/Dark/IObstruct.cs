using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IObstruct : MoveInstance
	{
		public IObstruct() : base( MoveObstruct.Instance ) {}
	}
}