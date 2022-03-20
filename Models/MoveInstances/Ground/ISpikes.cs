using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ISpikes : MoveInstance
	{
		public ISpikes() : base( MoveSpikes.Instance ) {}
	}
}