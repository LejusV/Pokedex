using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ISkyAttack : MoveInstance
	{
		public ISkyAttack() : base( MoveSkyAttack.Instance ) {}
	}
}