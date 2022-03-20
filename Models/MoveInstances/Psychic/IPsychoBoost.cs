using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IPsychoBoost : MoveInstance
	{
		public IPsychoBoost() : base( MovePsychoBoost.Instance ) {}
	}
}