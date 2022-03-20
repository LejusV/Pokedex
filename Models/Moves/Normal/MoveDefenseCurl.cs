using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises user's Defense by one stage.
	public class MoveDefenseCurl : Move
	{
#nullable enable
		private static MoveDefenseCurl? _instance = null;
#nullable restore
        public static MoveDefenseCurl Instance => _instance ?? (_instance = new MoveDefenseCurl());

		public MoveDefenseCurl() : base(
			"Defense-Curl",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			40, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}