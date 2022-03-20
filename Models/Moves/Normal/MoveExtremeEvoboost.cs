using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises all of the user's stats by two stages.
	public class MoveExtremeEvoboost : Move
	{
#nullable enable
		private static MoveExtremeEvoboost? _instance = null;
#nullable restore
        public static MoveExtremeEvoboost Instance => _instance ?? (_instance = new MoveExtremeEvoboost());

		public MoveExtremeEvoboost() : base(
			"Extreme-Evoboost",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			1, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}