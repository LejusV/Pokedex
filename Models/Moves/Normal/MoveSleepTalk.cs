using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Randomly uses one of the user's other three moves.  Only works if the user is sleeping.
	public class MoveSleepTalk : Move
	{
#nullable enable
		private static MoveSleepTalk? _instance = null;
#nullable restore
        public static MoveSleepTalk Instance => _instance ?? (_instance = new MoveSleepTalk());

		public MoveSleepTalk() : base(
			"Sleep-Talk",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}