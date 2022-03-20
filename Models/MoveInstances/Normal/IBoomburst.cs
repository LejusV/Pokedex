using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IBoomburst : MoveInstance
	{
		public IBoomburst() : base( MoveBoomburst.Instance ) {}
	}
}