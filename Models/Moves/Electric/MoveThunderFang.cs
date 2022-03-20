using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to paralyze the target and a 10% chance to make the target flinch.
	public class MoveThunderFang : Move
	{
#nullable enable
		private static MoveThunderFang? _instance = null;
#nullable restore
        public static MoveThunderFang Instance => _instance ?? (_instance = new MoveThunderFang());

		public MoveThunderFang() : base(
			"Thunder-Fang",
			Electric.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 65,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}