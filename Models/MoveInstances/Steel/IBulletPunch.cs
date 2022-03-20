using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IBulletPunch : MoveInstance
	{
		public IBulletPunch() : base( MoveBulletPunch.Instance ) {}
	}
}