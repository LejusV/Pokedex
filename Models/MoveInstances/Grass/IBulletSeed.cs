using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IBulletSeed : MoveInstance
	{
		public IBulletSeed() : base( MoveBulletSeed.Instance ) {}
	}
}