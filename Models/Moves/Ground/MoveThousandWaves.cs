using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Prevents the target from leaving battle.
	public class MoveThousandWaves : Move
	{
#nullable enable
		private static MoveThousandWaves? _instance = null;
#nullable restore
        public static MoveThousandWaves Instance => _instance ?? (_instance = new MoveThousandWaves());

		public MoveThousandWaves() : base(
			"Thousand-Waves",
			Ground.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 90,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}