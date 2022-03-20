using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Confuses the target.
	public class MoveTeeterDance : Move
	{
#nullable enable
		private static MoveTeeterDance? _instance = null;
#nullable restore
        public static MoveTeeterDance Instance => _instance ?? (_instance = new MoveTeeterDance());

		public MoveTeeterDance() : base(
			"Teeter-Dance",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}