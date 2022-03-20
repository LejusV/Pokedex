using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ISkillSwap : MoveInstance
	{
		public ISkillSwap() : base( MoveSkillSwap.Instance ) {}
	}
}