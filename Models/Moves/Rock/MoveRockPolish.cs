using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises the user's Speed by two stages.
	public class MoveRockPolish : Move
	{
#nullable enable
		private static MoveRockPolish? _instance = null;
#nullable restore
        public static MoveRockPolish Instance => _instance ?? (_instance = new MoveRockPolish());

		public MoveRockPolish() : base(
			"Rock-Polish",
			Rock.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}