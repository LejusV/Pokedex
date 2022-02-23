using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveHydroVortexPhysical : Move
	{
		public MoveHydroVortexPhysical() : base(
			"Hydro-Vortex--Physical",
			Water.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}