using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IConfusion : MoveInstance
	{
		public IConfusion() : base( MoveConfusion.Instance ) {}
	}
}