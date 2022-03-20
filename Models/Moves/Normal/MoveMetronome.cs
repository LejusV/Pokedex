using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Randomly selects and uses any move in the game.
	public class MoveMetronome : Move
	{
#nullable enable
		private static MoveMetronome? _instance = null;
#nullable restore
        public static MoveMetronome Instance => _instance ?? (_instance = new MoveMetronome());

		public MoveMetronome() : base(
			"Metronome",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}