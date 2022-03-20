using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Lowers the target's Attack by two stages.
	public class MoveFeatherDance : Move
	{
#nullable enable
		private static MoveFeatherDance? _instance = null;
#nullable restore
        public static MoveFeatherDance Instance => _instance ?? (_instance = new MoveFeatherDance());

		public MoveFeatherDance() : base(
			"Feather-Dance",
			Flying.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}