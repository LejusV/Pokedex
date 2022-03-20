using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises the user's Special Attack by two stages.
	public class MoveNastyPlot : Move
	{
#nullable enable
		private static MoveNastyPlot? _instance = null;
#nullable restore
        public static MoveNastyPlot Instance => _instance ?? (_instance = new MoveNastyPlot());

		public MoveNastyPlot() : base(
			"Nasty-Plot",
			Dark.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}