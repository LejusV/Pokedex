using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IPartingShot : MoveInstance
	{
		public IPartingShot() : base( MovePartingShot.Instance ) {}
	}
}