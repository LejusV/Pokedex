using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to make the target flinch.
	public class MoveAstonish : Move
	{
#nullable enable
		private static MoveAstonish? _instance = null;
#nullable restore
        public static MoveAstonish Instance => _instance ?? (_instance = new MoveAstonish());

		public MoveAstonish() : base(
			"Astonish",
			Ghost.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 30,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}