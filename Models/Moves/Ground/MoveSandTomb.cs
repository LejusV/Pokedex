using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Prevents the target from fleeing and inflicts damage for 2-5 turns.
	public class MoveSandTomb : Move
	{
#nullable enable
		private static MoveSandTomb? _instance = null;
#nullable restore
        public static MoveSandTomb Instance => _instance ?? (_instance = new MoveSandTomb());

		public MoveSandTomb() : base(
			"Sand-Tomb",
			Ground.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 35,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}