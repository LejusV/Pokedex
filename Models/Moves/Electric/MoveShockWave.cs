using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Never misses.
	public class MoveShockWave : Move
	{
#nullable enable
		private static MoveShockWave? _instance = null;
#nullable restore
        public static MoveShockWave Instance => _instance ?? (_instance = new MoveShockWave());

		public MoveShockWave() : base(
			"Shock-Wave",
			Electric.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 60,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}