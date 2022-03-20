using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IStealthRock : MoveInstance
	{
		public IStealthRock() : base( MoveStealthRock.Instance ) {}
	}
}