using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IHeartStamp : MoveInstance
	{
		public IHeartStamp() : base( MoveHeartStamp.Instance ) {}
	}
}