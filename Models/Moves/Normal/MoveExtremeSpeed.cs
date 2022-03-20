using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveExtremeSpeed : Move
	{
#nullable enable
		private static MoveExtremeSpeed? _instance = null;
#nullable restore
        public static MoveExtremeSpeed Instance => _instance ?? (_instance = new MoveExtremeSpeed());

		public MoveExtremeSpeed() : base(
			"Extreme-Speed",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 80,// PP & Pow
			100, 2 // Acc & Priority
		) {}
	}
}