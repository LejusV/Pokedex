using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IHelpingHand : MoveInstance
	{
		public IHelpingHand() : base( MoveHelpingHand.Instance ) {}
	}
}