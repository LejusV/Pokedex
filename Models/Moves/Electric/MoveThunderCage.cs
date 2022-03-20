using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveThunderCage : Move
	{
#nullable enable
		private static MoveThunderCage? _instance = null;
#nullable restore
        public static MoveThunderCage Instance => _instance ?? (_instance = new MoveThunderCage());

		public MoveThunderCage() : base(
			"Thunder-Cage",
			Electric.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 80,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}