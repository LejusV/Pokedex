using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's accuracy by one stage.
	public class MoveKinesis : Move
	{
#nullable enable
		private static MoveKinesis? _instance = null;
#nullable restore
        public static MoveKinesis Instance => _instance ?? (_instance = new MoveKinesis());

		public MoveKinesis() : base(
			"Kinesis",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			80, 0 // Acc & Priority
		) {}
	}
}