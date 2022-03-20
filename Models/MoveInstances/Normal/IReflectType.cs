using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IReflectType : MoveInstance
	{
		public IReflectType() : base( MoveReflectType.Instance ) {}
	}
}