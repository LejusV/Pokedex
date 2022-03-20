using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ISmog : MoveInstance
	{
		public ISmog() : base( MoveSmog.Instance ) {}
	}
}