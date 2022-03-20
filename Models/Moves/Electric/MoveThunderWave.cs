using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Paralyzes the target.
	public class MoveThunderWave : Move
	{
#nullable enable
		private static MoveThunderWave? _instance = null;
#nullable restore
        public static MoveThunderWave Instance => _instance ?? (_instance = new MoveThunderWave());

		public MoveThunderWave() : base(
			"Thunder-Wave",
			Electric.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}