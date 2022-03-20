using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IHyperFang : MoveInstance
	{
		public IHyperFang() : base( MoveHyperFang.Instance ) {}
	}
}