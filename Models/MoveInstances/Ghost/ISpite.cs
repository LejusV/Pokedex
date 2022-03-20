using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ISpite : MoveInstance
	{
		public ISpite() : base( MoveSpite.Instance ) {}
	}
}