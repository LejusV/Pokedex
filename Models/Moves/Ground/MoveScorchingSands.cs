using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveScorchingSands : Move
	{
#nullable enable
		private static MoveScorchingSands? _instance = null;
#nullable restore
        public static MoveScorchingSands Instance => _instance ?? (_instance = new MoveScorchingSands());

		public MoveScorchingSands() : base(
			"Scorching-Sands",
			Ground.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 70,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}