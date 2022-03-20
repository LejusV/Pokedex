using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Forces the target to repeat its last used move.
	public class MoveInstruct : Move
	{
#nullable enable
		private static MoveInstruct? _instance = null;
#nullable restore
        public static MoveInstruct Instance => _instance ?? (_instance = new MoveInstruct());

		public MoveInstruct() : base(
			"Instruct",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}