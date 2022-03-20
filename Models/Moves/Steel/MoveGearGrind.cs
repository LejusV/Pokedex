using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Hits twice in one turn.
	public class MoveGearGrind : Move
	{
#nullable enable
		private static MoveGearGrind? _instance = null;
#nullable restore
        public static MoveGearGrind Instance => _instance ?? (_instance = new MoveGearGrind());

		public MoveGearGrind() : base(
			"Gear-Grind",
			Steel.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 50,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}