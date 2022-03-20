using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Prevents any moves from hitting the user this turn.
	public class MoveDetect : Move
	{
#nullable enable
		private static MoveDetect? _instance = null;
#nullable restore
        public static MoveDetect Instance => _instance ?? (_instance = new MoveDetect());

		public MoveDetect() : base(
			"Detect",
			Fighting.Instance, // Move Type
			MoveCategory.Status, // Move Category
			5, null,// PP & Pow
			null, 4 // Acc & Priority
		) {}
	}
}