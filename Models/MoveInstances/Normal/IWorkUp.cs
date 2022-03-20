using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IWorkUp : MoveInstance
	{
		public IWorkUp() : base( MoveWorkUp.Instance ) {}
	}
}