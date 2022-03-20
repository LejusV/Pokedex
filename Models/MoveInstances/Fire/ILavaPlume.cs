using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ILavaPlume : MoveInstance
	{
		public ILavaPlume() : base( MoveLavaPlume.Instance ) {}
	}
}