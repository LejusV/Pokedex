using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class INaturePower : MoveInstance
	{
		public INaturePower() : base( MoveNaturePower.Instance ) {}
	}
}