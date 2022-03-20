using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 30% chance to make the target flinch.
	public class MoveIcicleCrash : Move
	{
#nullable enable
		private static MoveIcicleCrash? _instance = null;
#nullable restore
        public static MoveIcicleCrash Instance => _instance ?? (_instance = new MoveIcicleCrash());

		public MoveIcicleCrash() : base(
			"Icicle-Crash",
			Ice.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 85,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}