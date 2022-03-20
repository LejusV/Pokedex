using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ILeer : MoveInstance
	{
		public ILeer() : base( MoveLeer.Instance ) {}
	}
}