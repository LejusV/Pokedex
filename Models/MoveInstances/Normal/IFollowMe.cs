using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IFollowMe : MoveInstance
	{
		public IFollowMe() : base( MoveFollowMe.Instance ) {}
	}
}