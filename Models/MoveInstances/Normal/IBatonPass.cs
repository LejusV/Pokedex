using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IBatonPass : MoveInstance
	{
		public IBatonPass() : base( MoveBatonPass.Instance ) {}
	}
}