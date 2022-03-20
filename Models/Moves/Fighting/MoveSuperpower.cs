using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the user's Attack and Defense by one stage after inflicting damage.
	public class MoveSuperpower : Move
	{
#nullable enable
		private static MoveSuperpower? _instance = null;
#nullable restore
        public static MoveSuperpower Instance => _instance ?? (_instance = new MoveSuperpower());

		public MoveSuperpower() : base(
			"Superpower",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 120,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}