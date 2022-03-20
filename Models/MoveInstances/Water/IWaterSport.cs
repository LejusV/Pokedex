using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IWaterSport : MoveInstance
	{
		public IWaterSport() : base( MoveWaterSport.Instance ) {}
	}
}