using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Grounds the target, and hits even Flying-type or levitating Pokémon.
	public class MoveThousandArrows : Move
	{
#nullable enable
		private static MoveThousandArrows? _instance = null;
#nullable restore
        public static MoveThousandArrows Instance => _instance ?? (_instance = new MoveThousandArrows());

		public MoveThousandArrows() : base(
			"Thousand-Arrows",
			Ground.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 90,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}