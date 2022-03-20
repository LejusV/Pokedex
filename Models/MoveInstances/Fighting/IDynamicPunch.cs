using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IDynamicPunch : MoveInstance
	{
		public IDynamicPunch() : base( MoveDynamicPunch.Instance ) {}
	}
}