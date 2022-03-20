using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Cures the entire party of major status effects.
	public class MoveHealBell : Move
	{
#nullable enable
		private static MoveHealBell? _instance = null;
#nullable restore
        public static MoveHealBell Instance => _instance ?? (_instance = new MoveHealBell());

		public MoveHealBell() : base(
			"Heal-Bell",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			5, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}