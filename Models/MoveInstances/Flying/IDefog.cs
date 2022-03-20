using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IDefog : MoveInstance
	{
		public IDefog() : base( MoveDefog.Instance ) {}
	}
}