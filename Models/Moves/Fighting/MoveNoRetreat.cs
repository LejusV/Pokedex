using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Hits twice in one turn
	public class MoveNoRetreat : Move
	{
#nullable enable
		private static MoveNoRetreat? _instance = null;
#nullable restore
        public static MoveNoRetreat Instance => _instance ?? (_instance = new MoveNoRetreat());

		public MoveNoRetreat() : base(
			"No-Retreat",
			Fighting.Instance, // Move Type
			MoveCategory.Status, // Move Category
			5, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}