using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ICharm : MoveInstance
	{
		public ICharm() : base( MoveCharm.Instance ) {}
	}
}