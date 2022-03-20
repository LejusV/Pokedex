using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises user's Attack, Special Attack, and Speed by two stages.  Lower user's Defense and Special Defense by one stage.
	public class MoveShellSmash : Move
	{
#nullable enable
		private static MoveShellSmash? _instance = null;
#nullable restore
        public static MoveShellSmash Instance => _instance ?? (_instance = new MoveShellSmash());

		public MoveShellSmash() : base(
			"Shell-Smash",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}