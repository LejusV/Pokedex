using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IThunderPunch : MoveInstance
	{
		public IThunderPunch() : base( MoveThunderPunch.Instance ) {}
	}
}