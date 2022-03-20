using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IPrismaticLaser : MoveInstance
	{
		public IPrismaticLaser() : base( MovePrismaticLaser.Instance ) {}
	}
}