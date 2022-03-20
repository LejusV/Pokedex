using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IHealBlock : MoveInstance
	{
		public IHealBlock() : base( MoveHealBlock.Instance ) {}
	}
}