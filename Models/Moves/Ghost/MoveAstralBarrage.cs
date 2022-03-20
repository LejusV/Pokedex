using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveAstralBarrage : Move
	{
#nullable enable
		private static MoveAstralBarrage? _instance = null;
#nullable restore
        public static MoveAstralBarrage Instance => _instance ?? (_instance = new MoveAstralBarrage());

		public MoveAstralBarrage() : base(
			"Astral-Barrage",
			Ghost.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 120,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}