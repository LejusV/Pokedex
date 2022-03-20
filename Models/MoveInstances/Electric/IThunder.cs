using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IThunder : MoveInstance
	{
		public IThunder() : base( MoveThunder.Instance ) {}
	}
}