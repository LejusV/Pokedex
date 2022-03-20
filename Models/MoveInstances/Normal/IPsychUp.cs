using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IPsychUp : MoveInstance
	{
		public IPsychUp() : base( MovePsychUp.Instance ) {}
	}
}