using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IHypnosis : MoveInstance
	{
		public IHypnosis() : base( MoveHypnosis.Instance ) {}
	}
}