using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IExtrasensory : MoveInstance
	{
		public IExtrasensory() : base( MoveExtrasensory.Instance ) {}
	}
}