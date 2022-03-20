using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to paralyze the target.
	public class MoveThunder : Move
	{
#nullable enable
		private static MoveThunder? _instance = null;
#nullable restore
        public static MoveThunder Instance => _instance ?? (_instance = new MoveThunder());

		public MoveThunder() : base(
			"Thunder",
			Electric.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 110,// PP & Pow
			70, 0 // Acc & Priority
		) {}
	}
}