using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IUTurn : MoveInstance
	{
		public IUTurn() : base( MoveUTurn.Instance ) {}
	}
}