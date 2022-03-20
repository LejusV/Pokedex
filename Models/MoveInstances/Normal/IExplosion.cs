using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IExplosion : MoveInstance
	{
		public IExplosion() : base( MoveExplosion.Instance ) {}
	}
}