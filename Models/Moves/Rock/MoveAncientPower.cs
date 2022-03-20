using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to raise all of the user's stats by one stage.
	public class MoveAncientPower : Move
	{
#nullable enable
		private static MoveAncientPower? _instance = null;
#nullable restore
        public static MoveAncientPower Instance => _instance ?? (_instance = new MoveAncientPower());

		public MoveAncientPower() : base(
			"Ancient-Power",
			Rock.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 60,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}