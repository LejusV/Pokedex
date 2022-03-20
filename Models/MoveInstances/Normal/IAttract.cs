using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IAttract : MoveInstance
	{
		public IAttract() : base( MoveAttract.Instance ) {}
	}
}