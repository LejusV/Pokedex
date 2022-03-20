using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Prevents the target from fleeing and inflicts damage for 2-5 turns.
	public class MoveInfestation : Move
	{
#nullable enable
		private static MoveInfestation? _instance = null;
#nullable restore
        public static MoveInfestation Instance => _instance ?? (_instance = new MoveInfestation());

		public MoveInfestation() : base(
			"Infestation",
			Bug.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 20,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}