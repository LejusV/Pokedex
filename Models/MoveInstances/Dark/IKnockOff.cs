using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IKnockOff : MoveInstance
	{
		public IKnockOff() : base( MoveKnockOff.Instance ) {}
	}
}