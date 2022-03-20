using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IAssist : MoveInstance
	{
		public IAssist() : base( MoveAssist.Instance ) {}
	}
}