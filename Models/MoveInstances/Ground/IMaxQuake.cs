using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IMaxQuake : MoveInstance
	{
		public IMaxQuake() : base( MoveMaxQuake.Instance ) {}
	}
}