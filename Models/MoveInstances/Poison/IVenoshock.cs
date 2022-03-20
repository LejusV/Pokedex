using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IVenoshock : MoveInstance
	{
		public IVenoshock() : base( MoveVenoshock.Instance ) {}
	}
}