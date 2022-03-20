using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Power and type depend upon user's IVs.  Power can range from 30 to 70.
	public class MoveHiddenPower : Move
	{
#nullable enable
		private static MoveHiddenPower? _instance = null;
#nullable restore
        public static MoveHiddenPower Instance => _instance ?? (_instance = new MoveHiddenPower());

		public MoveHiddenPower() : base(
			"Hidden-Power",
			Normal.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 60,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}