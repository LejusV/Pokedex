using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class INaturalGift : MoveInstance
	{
		public INaturalGift() : base( MoveNaturalGift.Instance ) {}
	}
}