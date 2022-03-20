using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to paralyze the target.
	public class MoveThunderPunch : Move
	{
#nullable enable
		private static MoveThunderPunch? _instance = null;
#nullable restore
        public static MoveThunderPunch Instance => _instance ?? (_instance = new MoveThunderPunch());

		public MoveThunderPunch() : base(
			"Thunder-Punch",
			Electric.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 75,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}