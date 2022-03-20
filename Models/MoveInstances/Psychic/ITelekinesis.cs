using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ITelekinesis : MoveInstance
	{
		public ITelekinesis() : base( MoveTelekinesis.Instance ) {}
	}
}