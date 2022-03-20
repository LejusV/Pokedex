using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IIncinerate : MoveInstance
	{
		public IIncinerate() : base( MoveIncinerate.Instance ) {}
	}
}