using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises the user's Attack by one stage.
	public class MoveHowl : Move
	{
#nullable enable
		private static MoveHowl? _instance = null;
#nullable restore
        public static MoveHowl Instance => _instance ?? (_instance = new MoveHowl());

		public MoveHowl() : base(
			"Howl",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			40, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}