using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveSavageSpinOutSpecial : Move
	{
#nullable enable
		private static MoveSavageSpinOutSpecial? _instance = null;
#nullable restore
        public static MoveSavageSpinOutSpecial Instance => _instance ?? (_instance = new MoveSavageSpinOutSpecial());

		public MoveSavageSpinOutSpecial() : base(
			"Savage-Spin-Out--Special",
			Bug.Instance, // Move Type
			MoveCategory.Special, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}