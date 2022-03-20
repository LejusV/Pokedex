using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IThunderCage : MoveInstance
	{
		public IThunderCage() : base( MoveThunderCage.Instance ) {}
	}
}