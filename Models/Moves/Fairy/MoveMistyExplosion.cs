using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveMistyExplosion : Move
	{
#nullable enable
		private static MoveMistyExplosion? _instance = null;
#nullable restore
        public static MoveMistyExplosion Instance => _instance ?? (_instance = new MoveMistyExplosion());

		public MoveMistyExplosion() : base(
			"Misty-Explosion",
			Fairy.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 100,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}