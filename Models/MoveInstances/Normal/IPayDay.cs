using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IPayDay : MoveInstance
	{
		public IPayDay() : base( MovePayDay.Instance ) {}
	}
}