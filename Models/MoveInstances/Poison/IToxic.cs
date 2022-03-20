using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IToxic : MoveInstance
	{
		public IToxic() : base( MoveToxic.Instance ) {}
	}
}