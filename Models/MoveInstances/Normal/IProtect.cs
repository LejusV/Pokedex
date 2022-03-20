using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IProtect : MoveInstance
	{
		public IProtect() : base( MoveProtect.Instance ) {}
	}
}