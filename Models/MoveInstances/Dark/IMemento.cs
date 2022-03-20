using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IMemento : MoveInstance
	{
		public IMemento() : base( MoveMemento.Instance ) {}
	}
}