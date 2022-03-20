using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ITrumpCard : MoveInstance
	{
		public ITrumpCard() : base( MoveTrumpCard.Instance ) {}
	}
}