using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IFlareBlitz : MoveInstance
	{
		public IFlareBlitz() : base( MoveFlareBlitz.Instance ) {}
	}
}