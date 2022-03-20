using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IMeteorAssault : MoveInstance
	{
		public IMeteorAssault() : base( MoveMeteorAssault.Instance ) {}
	}
}