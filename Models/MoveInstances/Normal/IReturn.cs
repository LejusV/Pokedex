using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IReturn : MoveInstance
	{
		public IReturn() : base( MoveReturn.Instance ) {}
	}
}