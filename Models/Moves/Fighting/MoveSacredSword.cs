using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Ignores the target's stat modifiers.
	public class MoveSacredSword : Move
	{
#nullable enable
		private static MoveSacredSword? _instance = null;
#nullable restore
        public static MoveSacredSword Instance => _instance ?? (_instance = new MoveSacredSword());

		public MoveSacredSword() : base(
			"Sacred-Sword",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 90,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}