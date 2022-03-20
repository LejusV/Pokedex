using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveFieryWrath : Move
	{
#nullable enable
		private static MoveFieryWrath? _instance = null;
#nullable restore
        public static MoveFieryWrath Instance => _instance ?? (_instance = new MoveFieryWrath());

		public MoveFieryWrath() : base(
			"Fiery-Wrath",
			Dark.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 90,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}