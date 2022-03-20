using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class INeedleArm : MoveInstance
	{
		public INeedleArm() : base( MoveNeedleArm.Instance ) {}
	}
}