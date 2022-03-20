using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Prevents the user's HP from lowering below 1 this turn.
	public class MoveEndure : Move
	{
#nullable enable
		private static MoveEndure? _instance = null;
#nullable restore
        public static MoveEndure Instance => _instance ?? (_instance = new MoveEndure());

		public MoveEndure() : base(
			"Endure",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 4 // Acc & Priority
		) {}
	}
}