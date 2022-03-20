using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to make the target flinch.
	public class MoveHyperFang : Move
	{
#nullable enable
		private static MoveHyperFang? _instance = null;
#nullable restore
        public static MoveHyperFang Instance => _instance ?? (_instance = new MoveHyperFang());

		public MoveHyperFang() : base(
			"Hyper-Fang",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 80,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}