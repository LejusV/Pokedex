using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ICoreEnforcer : MoveInstance
	{
		public ICoreEnforcer() : base( MoveCoreEnforcer.Instance ) {}
	}
}