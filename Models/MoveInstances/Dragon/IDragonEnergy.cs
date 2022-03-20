using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IDragonEnergy : MoveInstance
	{
		public IDragonEnergy() : base( MoveDragonEnergy.Instance ) {}
	}
}