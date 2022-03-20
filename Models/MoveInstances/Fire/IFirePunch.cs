using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IFirePunch : MoveInstance
	{
		public IFirePunch() : base( MoveFirePunch.Instance ) {}
	}
}