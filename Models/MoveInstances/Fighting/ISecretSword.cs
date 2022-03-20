using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ISecretSword : MoveInstance
	{
		public ISecretSword() : base( MoveSecretSword.Instance ) {}
	}
}