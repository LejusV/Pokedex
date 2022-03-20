using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IQuash : MoveInstance
	{
		public IQuash() : base( MoveQuash.Instance ) {}
	}
}