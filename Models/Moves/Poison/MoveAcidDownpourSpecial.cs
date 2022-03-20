using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveAcidDownpourSpecial : Move
	{
#nullable enable
		private static MoveAcidDownpourSpecial? _instance = null;
#nullable restore
        public static MoveAcidDownpourSpecial Instance => _instance ?? (_instance = new MoveAcidDownpourSpecial());

		public MoveAcidDownpourSpecial() : base(
			"Acid-Downpour--Special",
			Poison.Instance, // Move Type
			MoveCategory.Special, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}