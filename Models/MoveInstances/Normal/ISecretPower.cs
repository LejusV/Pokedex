using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ISecretPower : MoveInstance
	{
		public ISecretPower() : base( MoveSecretPower.Instance ) {}
	}
}