using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IMeteorMash : MoveInstance
	{
		public IMeteorMash() : base( MoveMeteorMash.Instance ) {}
	}
}