using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IGeomancy : MoveInstance
	{
		public IGeomancy() : base( MoveGeomancy.Instance ) {}
	}
}