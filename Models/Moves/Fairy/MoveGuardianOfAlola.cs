using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Damages the target for 75% of its remaining HP.
	public class MoveGuardianOfAlola : Move
	{
#nullable enable
		private static MoveGuardianOfAlola? _instance = null;
#nullable restore
        public static MoveGuardianOfAlola Instance => _instance ?? (_instance = new MoveGuardianOfAlola());

		public MoveGuardianOfAlola() : base(
			"Guardian-Of-Alola",
			Fairy.Instance, // Move Type
			MoveCategory.Special, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}