using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Never misses.
	public class MoveVitalThrow : Move
	{
#nullable enable
		private static MoveVitalThrow? _instance = null;
#nullable restore
        public static MoveVitalThrow Instance => _instance ?? (_instance = new MoveVitalThrow());

		public MoveVitalThrow() : base(
			"Vital-Throw",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 70,// PP & Pow
			null, -1 // Acc & Priority
		) {}
	}
}