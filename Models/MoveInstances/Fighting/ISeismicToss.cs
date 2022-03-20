using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ISeismicToss : MoveInstance
	{
		public ISeismicToss() : base( MoveSeismicToss.Instance ) {}
	}
}