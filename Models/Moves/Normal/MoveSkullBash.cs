using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises the user's Defense by one stage.  User charges for one turn before attacking.
	public class MoveSkullBash : Move
	{
#nullable enable
		private static MoveSkullBash? _instance = null;
#nullable restore
        public static MoveSkullBash Instance => _instance ?? (_instance = new MoveSkullBash());

		public MoveSkullBash() : base(
			"Skull-Bash",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 130,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}