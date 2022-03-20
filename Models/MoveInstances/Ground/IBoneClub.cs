using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IBoneClub : MoveInstance
	{
		public IBoneClub() : base( MoveBoneClub.Instance ) {}
	}
}