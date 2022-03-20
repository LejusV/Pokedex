using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IOverheat : MoveInstance
	{
		public IOverheat() : base( MoveOverheat.Instance ) {}
	}
}