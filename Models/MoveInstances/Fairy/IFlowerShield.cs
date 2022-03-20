using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IFlowerShield : MoveInstance
	{
		public IFlowerShield() : base( MoveFlowerShield.Instance ) {}
	}
}