using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IPayback : MoveInstance
	{
		public IPayback() : base( MovePayback.Instance ) {}
	}
}