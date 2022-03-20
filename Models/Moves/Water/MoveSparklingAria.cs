using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Cures the target of burns.
	public class MoveSparklingAria : Move
	{
#nullable enable
		private static MoveSparklingAria? _instance = null;
#nullable restore
        public static MoveSparklingAria Instance => _instance ?? (_instance = new MoveSparklingAria());

		public MoveSparklingAria() : base(
			"Sparkling-Aria",
			Water.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 90,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}