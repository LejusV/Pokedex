using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IDrainPunch : MoveInstance
	{
		public IDrainPunch() : base( MoveDrainPunch.Instance ) {}
	}
}