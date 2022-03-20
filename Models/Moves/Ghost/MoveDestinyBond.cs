using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//If the user faints this turn, the target automatically will, too.
	public class MoveDestinyBond : Move
	{
#nullable enable
		private static MoveDestinyBond? _instance = null;
#nullable restore
        public static MoveDestinyBond Instance => _instance ?? (_instance = new MoveDestinyBond());

		public MoveDestinyBond() : base(
			"Destiny-Bond",
			Ghost.Instance, // Move Type
			MoveCategory.Status, // Move Category
			5, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}