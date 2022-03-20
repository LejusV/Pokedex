using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveHydroVortexSpecial : Move
	{
#nullable enable
		private static MoveHydroVortexSpecial? _instance = null;
#nullable restore
        public static MoveHydroVortexSpecial Instance => _instance ?? (_instance = new MoveHydroVortexSpecial());

		public MoveHydroVortexSpecial() : base(
			"Hydro-Vortex--Special",
			Water.Instance, // Move Type
			MoveCategory.Special, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}