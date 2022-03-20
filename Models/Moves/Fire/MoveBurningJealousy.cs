using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveBurningJealousy : Move
	{
#nullable enable
		private static MoveBurningJealousy? _instance = null;
#nullable restore
        public static MoveBurningJealousy Instance => _instance ?? (_instance = new MoveBurningJealousy());

		public MoveBurningJealousy() : base(
			"Burning-Jealousy",
			Fire.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 70,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}