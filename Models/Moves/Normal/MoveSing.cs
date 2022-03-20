using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Puts the target to sleep.
	public class MoveSing : Move
	{
#nullable enable
		private static MoveSing? _instance = null;
#nullable restore
        public static MoveSing Instance => _instance ?? (_instance = new MoveSing());

		public MoveSing() : base(
			"Sing",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			55, 0 // Acc & Priority
		) {}
	}
}