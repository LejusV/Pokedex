using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class INaturesMadness : MoveInstance
	{
		public INaturesMadness() : base( MoveNaturesMadness.Instance ) {}
	}
}