using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveInfernoOverdrivePhysical : Move
	{
#nullable enable
		private static MoveInfernoOverdrivePhysical? _instance = null;
#nullable restore
        public static MoveInfernoOverdrivePhysical Instance => _instance ?? (_instance = new MoveInfernoOverdrivePhysical());

		public MoveInfernoOverdrivePhysical() : base(
			"Inferno-Overdrive--Physical",
			Fire.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}