using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IShellTrap : MoveInstance
	{
		public IShellTrap() : base( MoveShellTrap.Instance ) {}
	}
}