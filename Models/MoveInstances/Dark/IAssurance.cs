using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IAssurance : MoveInstance
	{
		public IAssurance() : base( MoveAssurance.Instance ) {}
	}
}