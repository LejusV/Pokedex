using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Ensures that the user's next move will hit the target.
	public class MoveLockOn : Move
	{
#nullable enable
		private static MoveLockOn? _instance = null;
#nullable restore
        public static MoveLockOn Instance => _instance ?? (_instance = new MoveLockOn());

		public MoveLockOn() : base(
			"Lock-On",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			5, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}