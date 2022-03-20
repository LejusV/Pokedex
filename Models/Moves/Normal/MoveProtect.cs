using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Prevents any moves from hitting the user this turn.
	public class MoveProtect : Move
	{
#nullable enable
		private static MoveProtect? _instance = null;
#nullable restore
        public static MoveProtect Instance => _instance ?? (_instance = new MoveProtect());

		public MoveProtect() : base(
			"Protect",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 4 // Acc & Priority
		) {}
	}
}