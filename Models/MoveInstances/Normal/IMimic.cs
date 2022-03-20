using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IMimic : MoveInstance
	{
		public IMimic() : base( MoveMimic.Instance ) {}
	}
}