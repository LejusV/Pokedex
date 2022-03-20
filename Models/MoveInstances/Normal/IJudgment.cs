using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IJudgment : MoveInstance
	{
		public IJudgment() : base( MoveJudgment.Instance ) {}
	}
}