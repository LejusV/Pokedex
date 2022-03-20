using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to make the target flinch.
	public class MoveNeedleArm : Move
	{
#nullable enable
		private static MoveNeedleArm? _instance = null;
#nullable restore
        public static MoveNeedleArm Instance => _instance ?? (_instance = new MoveNeedleArm());

		public MoveNeedleArm() : base(
			"Needle-Arm",
			Grass.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 60,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}