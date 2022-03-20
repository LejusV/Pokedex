using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ICamouflage : MoveInstance
	{
		public ICamouflage() : base( MoveCamouflage.Instance ) {}
	}
}