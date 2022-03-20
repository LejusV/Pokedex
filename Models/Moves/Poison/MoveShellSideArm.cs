using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveShellSideArm : Move
	{
#nullable enable
		private static MoveShellSideArm? _instance = null;
#nullable restore
        public static MoveShellSideArm Instance => _instance ?? (_instance = new MoveShellSideArm());

		public MoveShellSideArm() : base(
			"Shell-Side-Arm",
			Poison.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 90,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}