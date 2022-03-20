using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ISoftBoiled : MoveInstance
	{
		public ISoftBoiled() : base( MoveSoftBoiled.Instance ) {}
	}
}