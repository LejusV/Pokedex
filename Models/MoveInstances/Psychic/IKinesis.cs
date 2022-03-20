using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IKinesis : MoveInstance
	{
		public IKinesis() : base( MoveKinesis.Instance ) {}
	}
}