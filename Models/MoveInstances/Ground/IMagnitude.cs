using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IMagnitude : MoveInstance
	{
		public IMagnitude() : base( MoveMagnitude.Instance ) {}
	}
}