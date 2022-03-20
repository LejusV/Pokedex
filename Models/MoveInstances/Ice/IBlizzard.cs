using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IBlizzard : MoveInstance
	{
		public IBlizzard() : base( MoveBlizzard.Instance ) {}
	}
}