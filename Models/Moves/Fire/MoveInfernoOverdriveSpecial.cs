using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveInfernoOverdriveSpecial : Move
	{
#nullable enable
		private static MoveInfernoOverdriveSpecial? _instance = null;
#nullable restore
        public static MoveInfernoOverdriveSpecial Instance => _instance ?? (_instance = new MoveInfernoOverdriveSpecial());

		public MoveInfernoOverdriveSpecial() : base(
			"Inferno-Overdrive--Special",
			Fire.Instance, // Move Type
			MoveCategory.Special, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}