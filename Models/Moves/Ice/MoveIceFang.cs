using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to freeze the target and a 10% chance to make the target flinch.
	public class MoveIceFang : Move
	{
#nullable enable
		private static MoveIceFang? _instance = null;
#nullable restore
        public static MoveIceFang Instance => _instance ?? (_instance = new MoveIceFang());

		public MoveIceFang() : base(
			"Ice-Fang",
			Ice.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 65,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}