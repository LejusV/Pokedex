using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveInfernoOverdrivePhysical : Move
	{
		public MoveInfernoOverdrivePhysical() : base(
			"Inferno-Overdrive--Physical",
			Fire.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}