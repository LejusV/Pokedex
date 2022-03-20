using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveStrength : Move
	{
#nullable enable
		private static MoveStrength? _instance = null;
#nullable restore
        public static MoveStrength Instance => _instance ?? (_instance = new MoveStrength());

		public MoveStrength() : base(
			"Strength",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}