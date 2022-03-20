using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to lower the target's Attack by one stage.
	public class MovePlayRough : Move
	{
#nullable enable
		private static MovePlayRough? _instance = null;
#nullable restore
        public static MovePlayRough Instance => _instance ?? (_instance = new MovePlayRough());

		public MovePlayRough() : base(
			"Play-Rough",
			Fairy.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 90,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}