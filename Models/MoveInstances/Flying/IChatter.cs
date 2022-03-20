using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IChatter : MoveInstance
	{
		public IChatter() : base( MoveChatter.Instance ) {}
	}
}