using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IWaterGun : MoveInstance
	{
		public IWaterGun() : base( MoveWaterGun.Instance ) {}
	}
}