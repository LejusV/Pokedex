using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Special Defense by two stages.
	public class MoveAcidSpray : Move
	{
#nullable enable
		private static MoveAcidSpray? _instance = null;
#nullable restore
        public static MoveAcidSpray Instance => _instance ?? (_instance = new MoveAcidSpray());

		public MoveAcidSpray() : base(
			"Acid-Spray",
			Poison.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 40,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}