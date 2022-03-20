using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 20% chance to confuse the target.
	public class MoveStrangeSteam : Move
	{
#nullable enable
		private static MoveStrangeSteam? _instance = null;
#nullable restore
        public static MoveStrangeSteam Instance => _instance ?? (_instance = new MoveStrangeSteam());

		public MoveStrangeSteam() : base(
			"Strange-Steam",
			Fairy.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 90,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}