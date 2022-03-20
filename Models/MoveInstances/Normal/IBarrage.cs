using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IBarrage : MoveInstance
	{
		public IBarrage() : base( MoveBarrage.Instance ) {}
	}
}