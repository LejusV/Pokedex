using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IPowerTrip : MoveInstance
	{
		public IPowerTrip() : base( MovePowerTrip.Instance ) {}
	}
}