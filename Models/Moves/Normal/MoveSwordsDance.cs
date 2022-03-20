using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises the user's Attack by two stages.
	public class MoveSwordsDance : Move
	{
#nullable enable
		private static MoveSwordsDance? _instance = null;
#nullable restore
        public static MoveSwordsDance Instance => _instance ?? (_instance = new MoveSwordsDance());

		public MoveSwordsDance() : base(
			"Swords-Dance",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}