using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveAcidDownpourPhysical : Move
	{
#nullable enable
		private static MoveAcidDownpourPhysical? _instance = null;
#nullable restore
        public static MoveAcidDownpourPhysical Instance => _instance ?? (_instance = new MoveAcidDownpourPhysical());

		public MoveAcidDownpourPhysical() : base(
			"Acid-Downpour--Physical",
			Poison.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}