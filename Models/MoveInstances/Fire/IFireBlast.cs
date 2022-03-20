using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IFireBlast : MoveInstance
	{
		public IFireBlast() : base( MoveFireBlast.Instance ) {}
	}
}