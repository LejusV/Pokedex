using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IDecorate : MoveInstance
	{
		public IDecorate() : base( MoveDecorate.Instance ) {}
	}
}