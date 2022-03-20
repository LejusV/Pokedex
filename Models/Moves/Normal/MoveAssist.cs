using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Randomly selects and uses one of the trainer's other Pokémon's moves.
	public class MoveAssist : Move
	{
#nullable enable
		private static MoveAssist? _instance = null;
#nullable restore
        public static MoveAssist Instance => _instance ?? (_instance = new MoveAssist());

		public MoveAssist() : base(
			"Assist",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}