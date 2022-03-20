using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IMagicalLeaf : MoveInstance
	{
		public IMagicalLeaf() : base( MoveMagicalLeaf.Instance ) {}
	}
}