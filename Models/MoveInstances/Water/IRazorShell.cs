using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IRazorShell : MoveInstance
	{
		public IRazorShell() : base( MoveRazorShell.Instance ) {}
	}
}