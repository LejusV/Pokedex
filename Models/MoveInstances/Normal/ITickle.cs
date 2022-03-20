using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ITickle : MoveInstance
	{
		public ITickle() : base( MoveTickle.Instance ) {}
	}
}