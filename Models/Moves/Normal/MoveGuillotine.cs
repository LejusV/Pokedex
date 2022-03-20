using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Causes a one-hit KO.
	public class MoveGuillotine : Move
	{
#nullable enable
		private static MoveGuillotine? _instance = null;
#nullable restore
        public static MoveGuillotine Instance => _instance ?? (_instance = new MoveGuillotine());

		public MoveGuillotine() : base(
			"Guillotine",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, null,// PP & Pow
			30, 0 // Acc & Priority
		) {}
	}
}