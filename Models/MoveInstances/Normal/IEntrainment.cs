using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IEntrainment : MoveInstance
	{
		public IEntrainment() : base( MoveEntrainment.Instance ) {}
	}
}