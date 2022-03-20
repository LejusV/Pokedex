using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IBodyPress : MoveInstance
	{
		public IBodyPress() : base( MoveBodyPress.Instance ) {}
	}
}