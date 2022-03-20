using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveHydroVortexPhysical : Move
	{
#nullable enable
		private static MoveHydroVortexPhysical? _instance = null;
#nullable restore
        public static MoveHydroVortexPhysical Instance => _instance ?? (_instance = new MoveHydroVortexPhysical());

		public MoveHydroVortexPhysical() : base(
			"Hydro-Vortex--Physical",
			Water.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}