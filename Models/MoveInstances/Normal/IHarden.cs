using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IHarden : MoveInstance
	{
		public IHarden() : base( MoveHarden.Instance ) {}
	}
}