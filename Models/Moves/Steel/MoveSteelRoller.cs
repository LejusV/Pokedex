using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveSteelRoller : Move
	{
#nullable enable
		private static MoveSteelRoller? _instance = null;
#nullable restore
        public static MoveSteelRoller Instance => _instance ?? (_instance = new MoveSteelRoller());

		public MoveSteelRoller() : base(
			"Steel-Roller",
			Steel.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 130,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}