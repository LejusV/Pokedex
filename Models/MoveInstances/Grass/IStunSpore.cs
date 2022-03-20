using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IStunSpore : MoveInstance
	{
		public IStunSpore() : base( MoveStunSpore.Instance ) {}
	}
}