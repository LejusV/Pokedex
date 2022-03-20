using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Prevents the target from fleeing and inflicts damage for 2-5 turns.
	public class MoveClamp : Move
	{
#nullable enable
		private static MoveClamp? _instance = null;
#nullable restore
        public static MoveClamp Instance => _instance ?? (_instance = new MoveClamp());

		public MoveClamp() : base(
			"Clamp",
			Water.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 35,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}