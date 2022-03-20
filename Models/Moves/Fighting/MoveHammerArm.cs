using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers user's Speed by one stage.
	public class MoveHammerArm : Move
	{
#nullable enable
		private static MoveHammerArm? _instance = null;
#nullable restore
        public static MoveHammerArm Instance => _instance ?? (_instance = new MoveHammerArm());

		public MoveHammerArm() : base(
			"Hammer-Arm",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 100,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}