using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IFoulPlay : MoveInstance
	{
		public IFoulPlay() : base( MoveFoulPlay.Instance ) {}
	}
}