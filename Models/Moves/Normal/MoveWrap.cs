using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Prevents the target from fleeing and inflicts damage for 2-5 turns.
	public class MoveWrap : Move
	{
#nullable enable
		private static MoveWrap? _instance = null;
#nullable restore
        public static MoveWrap Instance => _instance ?? (_instance = new MoveWrap());

		public MoveWrap() : base(
			"Wrap",
			Normal.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 15,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}