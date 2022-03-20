using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ICoil : MoveInstance
	{
		public ICoil() : base( MoveCoil.Instance ) {}
	}
}