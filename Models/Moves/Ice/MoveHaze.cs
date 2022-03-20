using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Resets all Pokémon's stats, accuracy, and evasion.
	public class MoveHaze : Move
	{
#nullable enable
		private static MoveHaze? _instance = null;
#nullable restore
        public static MoveHaze Instance => _instance ?? (_instance = new MoveHaze());

		public MoveHaze() : base(
			"Haze",
			Ice.Instance, // Move Type
			MoveCategory.Status, // Move Category
			30, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}