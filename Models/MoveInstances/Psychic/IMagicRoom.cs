using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IMagicRoom : MoveInstance
	{
		public IMagicRoom() : base( MoveMagicRoom.Instance ) {}
	}
}